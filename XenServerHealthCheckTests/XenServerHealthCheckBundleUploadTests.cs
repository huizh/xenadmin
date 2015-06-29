using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XenServerHealthCheck;
using System.Net;
using XenAPI;
using XenAdmin.Network;
using XenAdmin.Core;
using XenAdmin;

namespace XenServerHealthCheckTests
{
    class XenServerHealthCheckBundleUploadTests
    {
        private static string uploadToken = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJidHMuY2lzLmNpdHJpeC5jb20iLCJpYXQiOjE0MzU1NjA1MTUsImp0aSI6IjliNjhiOTIyLWFmMDMtNDA3MC05M2IxLTJmMjdlNDRmZGNkZCIsInN1YiI6ImZlZWRzIiwiYnRzLmNpcy5jaXRyaXguY29tIjp7ImNjIjp7InJlYWxtIjoiTXlDaXRyaXgiLCJjb21wYW55IjozLCJ1c2VyIjoidF9odWl6IiwicGsiOiJmOGQ0NTNiOTExYTMzY2JiNjI5MTVkODk5YTAyMjY0MTliMjYwOTM1IiwidHlwZSI6IlVQTE9BRCIsImluaXRpYXRpbmciOiI5MjVkNzMzNi0zNzcyLTRlZmEtYmFkZi0xNDAzZjc0NDRjMWYifSwiaXIiOmZhbHNlfX0.PHjkUfpmymrfcjDcOnHEEX4IFrCX2hK_PiMMTcjgm8VvvswBsxS3_ZJC7V2vEcyQurhT6S1L38hbuf1nrIFS16u1rI6YP3R_x0B3TtutEAw0rbTmwansEnZk_Wsj8xmUNfJ6lIgARSzVnsFpRvOyWZD1az9V8VoYPHp4TphVu489mvpApxvSx2L_v-BugWoP6QxPWKj9FGR4atGBG2fWhwLifapt_z2NWjPllJo_sMA7yi77FhaL218HYjLwPii_Pfg9il4___0X7msLmrfAXUOGpmi7MTkjJVeU7mN-slUKSDCqoqWYO1Lm8qgW9igexZGT3v0cPxHPh4GkQRCiBQ";
        //private static string fileToUpload = "C:\\Users\\huiz\\Desktop\\status-report-2015-06-09-10-24-34.zip";

        public void uploadTest()
        {
            XenAdminConfigManager.Provider = new WinformsXenAdminConfigProvider();

            IXenConnection connection = new XenConnection();
            connection.Username = "root";
            connection.Hostname = "cl09-A-02.xenrt.citrite.net";
            connection.Port = ConnectionsManager.DEFAULT_XEN_PORT;
            connection.Password = "xenroot";
            //XenAPI.Session _session = new Session(connection.Hostname, 80);
            //_session.APIVersion = API_Version.LATEST;


            //_session.login_with_password(connection.Username, connection.Password);

            //if (_session != null)
            //{
            //    connection.LoadCache(_session);
            //    XenServerHealthCheckBugTool bugTool = new XenServerHealthCheckBugTool();
            //    bugTool.RunBugtool(connection, _session);

            //    _session.logout();

            //    System.Threading.CancellationToken cancel = new System.Threading.CancellationToken();
            //    XenServerHealthCheckUpload uploadInstance = new XenServerHealthCheckUpload(uploadToken, 2);
            //    string uploadUuid = uploadInstance.UploadZip(bugTool.outputFile, cancel);
            //    return;
            //}

            XenServerHealthCheckBundleUpload upload = new XenServerHealthCheckBundleUpload(connection);
            upload.runUpload();
            return;
        }



    }
}
