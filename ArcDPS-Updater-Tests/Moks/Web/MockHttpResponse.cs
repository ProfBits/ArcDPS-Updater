using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ArcDPS_Updater_Tests.Moks.Web
{
    class MockHttpResponse : ArcDPS_Updater.Wrapper.Web.IHttpResponse
    {
        public MockHttpResponse(HttpStatusCode oK, string v)
        {
        }

        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessStatusCode { get; }
        public HttpContent Content { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage EnsureSuccessStatusCode()
        {
            throw new NotImplementedException();
        }
    }
}
