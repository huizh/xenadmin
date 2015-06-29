/* Copyright (c) Citrix Systems Inc. 
 * All rights reserved. 
 * 
 * Redistribution and use in source and binary forms, 
 * with or without modification, are permitted provided 
 * that the following conditions are met: 
 * 
 * *   Redistributions of source code must retain the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer. 
 * *   Redistributions in binary form must reproduce the above 
 *     copyright notice, this list of conditions and the 
 *     following disclaimer in the documentation and/or other 
 *     materials provided with the distribution. 
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
 * CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
 * INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR 
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, 
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
 * BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR 
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
 * WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE 
 * OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF 
 * SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using XenAdmin.Core;
using XenAdmin.Network;
using XenAPI;


namespace XenServerHealthCheck
{
    public class XenServerHealthCheckBundleUpload
    {
        public XenServerHealthCheckBundleUpload(IXenConnection _connection)
        {
            connection = _connection;
        }

        private IXenConnection connection;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public const int TIMEOUT = 24 * 60 * 60 * 1000;
        public const int VERBOSITY_LEVEL = 2;

        public void runUpload()
        {
            DateTime startTime = DateTime.UtcNow;
            string uploadToken;
            Session session = new Session(connection.Hostname, 80);
            session.APIVersion = API_Version.LATEST;

            try
            {
                session.login_with_password(connection.Username, connection.Password);
                connection.LoadCache(session);
                //Dictionary<string, string> config = Pool.get_gui_config(session, connection.Cache.Pools[0].opaque_ref);
                var pool = Helpers.GetPoolOfOne(connection);
                if (pool != null)
                {
                    uploadToken = pool.CallHomeSettings.GetUploadToken(connection);
                }
                // CallHomeSettings callHomeSettings = new CallHomeSettings(config);
                // Fetch the CIS uploading token.
                // uploadToken = callHomeSettings.GetUploadToken(connection);
                uploadToken = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJidHMuY2lzLmNpdHJpeC5jb20iLCJpYXQiOjE0MzU1NjA1MTUsImp0aSI6IjliNjhiOTIyLWFmMDMtNDA3MC05M2IxLTJmMjdlNDRmZGNkZCIsInN1YiI6ImZlZWRzIiwiYnRzLmNpcy5jaXRyaXguY29tIjp7ImNjIjp7InJlYWxtIjoiTXlDaXRyaXgiLCJjb21wYW55IjozLCJ1c2VyIjoidF9odWl6IiwicGsiOiJmOGQ0NTNiOTExYTMzY2JiNjI5MTVkODk5YTAyMjY0MTliMjYwOTM1IiwidHlwZSI6IlVQTE9BRCIsImluaXRpYXRpbmciOiI5MjVkNzMzNi0zNzcyLTRlZmEtYmFkZi0xNDAzZjc0NDRjMWYifSwiaXIiOmZhbHNlfX0.PHjkUfpmymrfcjDcOnHEEX4IFrCX2hK_PiMMTcjgm8VvvswBsxS3_ZJC7V2vEcyQurhT6S1L38hbuf1nrIFS16u1rI6YP3R_x0B3TtutEAw0rbTmwansEnZk_Wsj8xmUNfJ6lIgARSzVnsFpRvOyWZD1az9V8VoYPHp4TphVu489mvpApxvSx2L_v-BugWoP6QxPWKj9FGR4atGBG2fWhwLifapt_z2NWjPllJo_sMA7yi77FhaL218HYjLwPii_Pfg9il4___0X7msLmrfAXUOGpmi7MTkjJVeU7mN-slUKSDCqoqWYO1Lm8qgW9igexZGT3v0cPxHPh4GkQRCiBQ";
                if (string.IsNullOrEmpty(uploadToken))
                {
                    if (session != null)
                        session.logout();
                    session = null;
                    log.ErrorFormat("The upload token is not retrieved for {0}", connection.Hostname);
                    updateCallHomeSettings(false, startTime);
                    return;
                }

            }
            catch (Exception e)
            {
                if (session != null)
                    session.logout();
                session = null;
                log.Error(e, e);
                updateCallHomeSettings(false, startTime);
                return;
            }

            try
            {
                CancellationTokenSource cts = new CancellationTokenSource();
                Func<string> upload = delegate()
                {
                    try
                    {
                        return bundleUpload(connection, session, uploadToken, cts.Token);
                    }
                    catch (OperationCanceledException)
                    {
                        return "";
                    }
                };
                System.Threading.Tasks.Task<string> task = new System.Threading.Tasks.Task<string>(upload);
                task.Start();
                //if (!task.Wait(TIMEOUT))
                if (!task.Wait(1000))
                {
                    cts.Cancel();
                    updateCallHomeSettings(false, startTime);
                    //return;
                    System.Threading.Thread.Sleep(1000 * 600);
                }

                if (task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
                {
                    string upload_uuid = task.Result;
                    if(!string.IsNullOrEmpty(upload_uuid))
                        updateCallHomeSettings(true, startTime, upload_uuid);
                    else
                        updateCallHomeSettings(false, startTime);
                }
                else
                    updateCallHomeSettings(false, startTime);
            }
            catch (Exception e)
            {
                if (session != null)
                    session.logout();
                session = null;
                log.Error(e, e);
                updateCallHomeSettings(false, startTime);
            }

        }

        public void updateCallHomeSettings(bool success, DateTime time, string uploadUuid = "")
        {
            Session session = new Session(connection.Hostname, 80);
            session.login_with_password(connection.Username, connection.Password);
            connection.LoadCache(session);

            // record upload_uuid,
            // release the lock,
            // set the time of LAST_SUCCESSFUL_UPLOAD or LAST_FAILED_UPLOAD
            Dictionary<string, string> config = Pool.get_gui_config(session, connection.Cache.Pools[0].opaque_ref);
            config[CallHomeSettings.UPLOAD_LOCK] = "";
            if (success)
            {
                config[CallHomeSettings.LAST_SUCCESSFUL_UPLOAD] = time.ToString();
                // UPLOAD_UUID is missed in CallHomeSettings
                // config[CallHomeSettings.UPLOAD_UUID] = uploadUuid;
            }
            else
                config[CallHomeSettings.LAST_FAILED_UPLOAD] = time.ToString();
            Pool.set_gui_config(session, connection.Cache.Pools[0].opaque_ref, config);

            if (session != null)
                session.logout();
            session = null;
        }

        public string bundleUpload(IXenConnection connection, Session session, string uploadToken, System.Threading.CancellationToken cancel)
        {
            XenServerHealthCheckBugTool bugTool = new XenServerHealthCheckBugTool();
            try
            {
                bugTool.RunBugtool(connection, session);
            }
            catch (Exception e)
            {
                if (session != null)
                    session.logout();
                session = null;
                log.Error(e, e);
                return "";
            }

            string bundleToUpload = bugTool.outputFile;

            // Check if the logs are collected as expected.
            if(string.IsNullOrEmpty(bundleToUpload) || !File.Exists(bundleToUpload))
            {
                log.ErrorFormat("Server Status Report is NOT collected");
                return "";
            }

            // Upload the zip file to CIS uploading server.
            XenServerHealthCheckUpload upload = new XenServerHealthCheckUpload(uploadToken, VERBOSITY_LEVEL);
            string upload_uuid = upload.UploadZip(bundleToUpload, cancel);
            if(string.IsNullOrEmpty(upload_uuid))
            {
                // Fail to upload the zip to CIS server.
                log.ErrorFormat("Fail to upload the Server Status Report {0} to CIS server", bundleToUpload);
                return "";
            }

            return upload_uuid;
        }
    }
}
