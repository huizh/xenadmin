using System;
namespace XenServerHealthCheckTests
{
    class Program
    {
        static void Main(string[] args)
        {
            //RequestUploadTaskTests requestUploadTaskTests = new RequestUploadTaskTests();
            //requestUploadTaskTests.checkUploadLock();
            //requestUploadTaskTests.checkDemandLock();
            XenServerHealthCheckBundleUploadTests bundleUploadTest = new XenServerHealthCheckBundleUploadTests();
            bundleUploadTest.uploadTest();

        }
    }
}
