using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebMVC.Infrastructure;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class CakeService : ICakeService
    {
        private readonly IHttpClient _client;
        private readonly string _baseUri;

        public CakeService(IConfiguration config, IHttpClient client)
        {
            _baseUri = $"{config["CakeUrl"]}/api/Cake/";
            _client = client;
        }

        public async Task<CakeList> Cakes()
        {
            var CakesUri = ApiPath.Cake.GetAllTypes(_baseUri);
            var dataString = await _client.GetStringAsync(CakesUri);
            var cakeList = new CakeList
            {
                Cake = JsonConvert.DeserializeObject<List<Cake>>(dataString)
            };
            
            return cakeList;
        }
    }
}



