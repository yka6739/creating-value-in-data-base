using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication31.Client.Http
{
    public class HttpResponceWrapper<T>
    {
        public HttpResponceWrapper(T response, bool success, HttpResponseMessage httpResponseMessage)
        {
            Success = success;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }
        public bool Success { get; set; }
        public T Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
        public async Task<string>GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
   
}
