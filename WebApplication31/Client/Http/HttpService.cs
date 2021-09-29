﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication31.Client.Http
{
    public class HttpService: IHttpService
    {
        private readonly HttpClient httpClient;

        public HttpService(HttpClient httpClient)
        {
            this.httpClient = httpClient;     
        }
        public async Task<HttpResponceWrapper<object>>Post<T>(string url, T data)
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);
            return new HttpResponceWrapper<object>(null, response.IsSuccessStatusCode, response);
        }
    }
}
