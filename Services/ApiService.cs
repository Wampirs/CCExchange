using CCExchange.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows;

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


        public async Task<List<Currency>> GetCurrenciesAsync(int count = -1)
        {
                string requestUri = new string("v2/assets");
                if (count > 0) requestUri = requestUri + $"?limit={count}";
                HttpResponseMessage response = await api.GetAsync(requestUri).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var res = await response.Content.ReadAsStringAsync();
                var rootJson = JsonConvert.DeserializeObject<JsonArray<Currency>>(res);
                return rootJson.Data;
        }

        public async Task<Currency> GetCurrencyAsync(string id)
        {
            string requestUri = new string($"v2/assets/{id}");
            HttpResponseMessage response = await api.GetAsync(requestUri).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var res = await response.Content.ReadAsStringAsync();
            var rootJson = JsonConvert.DeserializeObject<JsonObject<Currency>>(res);
            return rootJson.Data;
        }
    }
}
