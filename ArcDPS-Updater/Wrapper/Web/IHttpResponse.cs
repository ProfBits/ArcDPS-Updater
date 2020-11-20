using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ArcDPS_Updater.Wrapper.Web
{
    public interface IHttpResponse : IDisposable
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessStatusCode { get; }
        public HttpContent Content { get; set; }
        public HttpResponseMessage EnsureSuccessStatusCode();
    }
}
