using CCExchange.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CCExchange.Services
{
    public class ApiService : IApiService
    {
        HttpClient api;
        const string apiAddress = "https://api.coincap.io";


        public ApiService()
        {
            api = new HttpClient();
            api.BaseAddress = new Uri(apiAddress);
            api.DefaultRequestHeaders.Add("User-Agent", "C# console program");
            api.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
        }


        public async Task<List<Currency>> GetCurrenciesAsync()
        {
            string requestUri = new string("v2/assets");
            HttpResponseMessage response = await api.GetAsync(requestUri).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var res = await response.Content.ReadAsStringAsync();
            var rootJson = JsonConvert.DeserializeObject<RootJson>(res);
            return rootJson.Data;
        }
    }
}
