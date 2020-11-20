using System;
using System.Collections.Generic;
using System.Text;

namespace ArcDPS_Updater_Tests.Moks.MD5
{
    class MockMD5Provider : ArcDPS_Updater.Wrapper.MD5.IMd5Provider
    {
        public string ReqeustedPaht { get; private set; } = null;
        private string Return;

        public MockMD5Provider(string @return)
        {
            Return = @return;
        }

        public string GetMd5Hash(string filePath)
        {
            ReqeustedPaht = filePath;
            return Return;
        }
    }
}
