using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArcDPS_Updater.Wrapper.Web
{
    public interface IHttpClient : IDisposable
    {
        static IWebProxy DefaultProxy { get; set; }
        HttpRequestHeaders DefaultRequestHeaders { get; }
        TimeSpan Timeout { get; set; }
        
        Task<IHttpResponse> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);
        Task<IHttpResponse> DeleteAsync(Uri requestUri);
        Task<IHttpResponse> GetAsync(Uri requestUri, CancellationToken cancellationToken);
        Task<IHttpResponse> GetAsync(Uri requestUri);
        Task<IHttpResponse> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        Task<IHttpResponse> GetAsync(Uri requestUri, HttpCompletionOption completionOption);
        Task<Stream> GetStreamAsync(Uri requestUri);
        Task<string> GetStringAsync(Uri requestUri);
        Task<byte[]> GetByteArrayAsync(Uri requestUri);
        Task<IHttpResponse> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        Task<IHttpResponse> PatchAsync(Uri requestUri, HttpContent content);
        Task<IHttpResponse> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        Task<IHttpResponse> PostAsync(Uri requestUri, HttpContent content);
        Task<IHttpResponse> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        Task<IHttpResponse> PutAsync(Uri requestUri, HttpContent content);
    }
}
