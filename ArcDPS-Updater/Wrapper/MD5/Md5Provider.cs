using System;
using System.Collections.Generic;
using System.Text;

namespace ArcDPS_Updater.Wrapper.MD5
{
    public class Md5Provider : IMd5Provider
    {
        public string GetMd5Hash(string filePath)
        {
            return Encoding.UTF8.GetString(System.Security.Cryptography.MD5.Create().ComputeHash(System.IO.File.ReadAllBytes(filePath)));
        }
    }
}
