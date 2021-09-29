using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.Client.Http
{
    public interface IHttpService
    {
        Task<HttpResponceWrapper<object>> Post<T>(string url, T data);
    }
}
