using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using ArcDPS_Updater_Tests.Moks.Web;
using ArcDPS_Updater_Tests.Moks.MD5;
using System.Net;

namespace ArcDPS_Updater_Tests
{
    [TestClass]
    public class VersionCheckTest
    {
        [TestMethod]
        public void NewVersionAvailable()
        {
            var response = new MockHttpResponse(HttpStatusCode.OK, "md5sum");
            var client = new MockHttpClient(answers: new Answer(new Uri("bla"), response));
            var md5Provider = new MockMD5Provider("md5sum");

            var versionCheck = new ArcDPS_Updater.Tools.VersionCheck(client, md5Provider);
            bool res = versionCheck.NewVersionAvailable("arcpath");
            Assert.IsTrue(res, "New Version should be availabe, md5 is diffrent");
        }

        [TestMethod]
        public void NoNewVersion()
        {
            var response = new MockHttpResponse(HttpStatusCode.OK, "md5sum");
            var client = new MockHttpClient(answers: new Answer(new Uri("bla"), response));
            var md5Provider = new MockMD5Provider("md5sum");

            var versionCheck = new ArcDPS_Updater.Tools.VersionCheck(client, md5Provider);
            bool res = versionCheck.NewVersionAvailable("arcpath");
            Assert.IsTrue(res, "New Version should be availabe, md5 is diffrent");
        }

        [TestMethod]
        public void InvalidPath()
        {
            var response = new MockHttpResponse(HttpStatusCode.OK, "md5sum");
            var client = new MockHttpClient(answers: new Answer(new Uri("bla"), response));
            var md5Provider = new MockMD5Provider("md5sum");

            var versionCheck = new ArcDPS_Updater.Tools.VersionCheck(client, md5Provider);
            Assert.ThrowsException<ArgumentException>(() => versionCheck.NewVersionAvailable("invalidarcpath"));
        }

        [TestMethod]
        public void NullPath()
        {
            var response = new MockHttpResponse(HttpStatusCode.OK, "md5sum");
            var client = new MockHttpClient(answers: new Answer(new Uri("bla"), response));
            var md5Provider = new MockMD5Provider("md5sum");

            var versionCheck = new ArcDPS_Updater.Tools.VersionCheck(client, md5Provider);
            Assert.ThrowsException<ArgumentNullException>(() => versionCheck.NewVersionAvailable(null));
        }

        [TestMethod]
        public void HttpClientNull()
        {
            var md5Provider = new MockMD5Provider("md5sum");

            Assert.ThrowsException<ArgumentNullException>(() => new ArcDPS_Updater.Tools.VersionCheck(null, md5Provider));
        }

        [TestMethod]
        public void Md5ProviderNull()
        {
            var response = new MockHttpResponse(HttpStatusCode.OK, "md5sum");
            var client = new MockHttpClient(answers: new Answer(new Uri("bla"), response));

            Assert.ThrowsException<ArgumentNullException>(() => new ArcDPS_Updater.Tools.VersionCheck(client, null));
        }

        [TestMethod]
        public void Md5ProviderAndHttpClientNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new ArcDPS_Updater.Tools.VersionCheck(null, null));
        }
    }
}
