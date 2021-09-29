using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication31.Client.Http;
using WebApplication31.Shared.Entities;

namespace WebApplication31.Client.FormServices
{
    public class FormClass:FormInterface
    {
        private readonly IHttpService httpService;
        private string url = "api/onlines";
        public FormClass(IHttpService httpService)
        {
            this.httpService = httpService;

        }
        public async Task CreateShop(OnlineProduct onlineProduct)
        {
            var response = await httpService.Post(url, onlineProduct);
            if(!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
