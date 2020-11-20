using ArcDPS_Updater.Wrapper.Web;

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ArcDPS_Updater_Tests.Moks.Web
{
    class MockHttpClient : ArcDPS_Updater.Wrapper.Web.IHttpClient
    {
        private const string InvalidEndpoint = "Not Registerd endpoint";
        private readonly List<Answer> Responses;
        private int m_MinResponseTimeMs = 50;
        internal int MinResponseTimeMs { get => m_MinResponseTimeMs; set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("ResponstimeMs must be > 0");
                m_MinResponseTimeMs = value;
            }
        }

        private readonly List<Args> Calls = new List<Args>();
        internal IReadOnlyList<Args> Reqeusts { get => Calls; }

        public MockHttpClient(string answer = null, byte[] banswer = null, Stream sanswer = null, params Answer[] answers)
        {
            Responses = answers.ToList();
            StrResponse = answer;
            ByteResponse = banswer;
            StreamResponse = sanswer;
        }

        public HttpRequestHeaders DefaultRequestHeaders { get; }
        public TimeSpan Timeout { get; set; }
        public object StreamResponse { get; set; }
        public byte [] ByteResponse { get; set; }
        public string StrResponse { get; set; }

        public async Task<IHttpResponse> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            Calls.Add(new Args(HttpMethod.Delete, requestUri));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> DeleteAsync(Uri requestUri)
        {
            Calls.Add(new Args(HttpMethod.Delete, requestUri));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IHttpResponse> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            Calls.Add(new Args(HttpMethod.Get, requestUri));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> GetAsync(Uri requestUri)
        {
            Calls.Add(new Args(HttpMethod.Get, requestUri));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            Calls.Add(new Args(HttpMethod.Get, requestUri));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            Calls.Add(new Args(HttpMethod.Get, requestUri));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<byte[]> GetByteArrayAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public async Task<Stream> GetStreamAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetStringAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public async Task<IHttpResponse> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            Calls.Add(new Args(HttpMethod.Patch, requestUri, content));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> PatchAsync(Uri requestUri, HttpContent content)
        {
            Calls.Add(new Args(HttpMethod.Patch, requestUri, content));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            Calls.Add(new Args(HttpMethod.Post, requestUri, content));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> PostAsync(Uri requestUri, HttpContent content)
        {
            Calls.Add(new Args(HttpMethod.Post, requestUri, content));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            Calls.Add(new Args(HttpMethod.Put, requestUri, content));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }

        public async Task<IHttpResponse> PutAsync(Uri requestUri, HttpContent content)
        {
            Calls.Add(new Args(HttpMethod.Put, requestUri, content));
            var answer = Responses.FirstOrDefault(a => a.Uri.Equals(requestUri));
            if (answer.Equals(default(Answer))) throw new InvalidDataException(InvalidEndpoint);
            Responses.Remove(answer);
            await Task.Delay(m_MinResponseTimeMs);
            return answer.Response;
        }
    }

    internal class Args
    {
        internal HttpMethod Method { get; }
        internal Uri Uri { get; }
        internal HttpContent HttpContent { get; }

        public Args(HttpMethod method, Uri uri, HttpContent httpContent = null)
        {
            Method = method ?? throw new ArgumentNullException();
            Uri = uri ?? throw new ArgumentNullException(); ;
            HttpContent = httpContent;
        }
    }
}
