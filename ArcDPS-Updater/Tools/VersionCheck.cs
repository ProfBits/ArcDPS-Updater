using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ArcDPS_Updater.Wrapper.Web;
using ArcDPS_Updater.Wrapper.MD5;

namespace ArcDPS_Updater.Tools
{
    public class VersionCheck : IDisposable
    {
        private readonly IHttpClient HttpClient;
        private readonly IMd5Provider Md5Provider;
        private bool disposedValue;

        public VersionCheck(IHttpClient httpClient, IMd5Provider md5Provider)
        {
            throw new NotImplementedException();
        }

        public bool NewVersionAvailable(string v)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~VersionCheck()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
