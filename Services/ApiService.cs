using CCExchange.Models;
using CCExchange.Models.Base;
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


        public List<Currency> GetCurrenciesAsync(int count = -1)
        {
            string requestUri = new string("v2/assets");
            if (count > 0) requestUri = requestUri + $"?limit={count}";
            try
            {
                var rootJson = JsonConvert.DeserializeObject<JsonArray<Currency>>(RequestApi(requestUri));
                return rootJson.Data;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return new List<Currency>();
            }
            
        }

        public Currency GetCurrencyAsync(string id)
        {
            string requestUri = new string($"v2/assets/{id}");
            try
            {
                var rootJson = JsonConvert.DeserializeObject<JsonObject<Currency>>(RequestApi(requestUri));
                return rootJson.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new Currency();
            }
        }

        public List<Market> GetMarketsAsync(string curId)
        {
            string requestUri = new string($"v2/assets/{curId}/markets");
            try
            {
                var rootJson = JsonConvert.DeserializeObject<JsonArray<Market>>(RequestApi(requestUri));
                return rootJson.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Market>();
            }            
        }

        public string RequestApi(string requestString)
        {
            try
            {
                HttpResponseMessage response = api.GetAsync(requestString).Result;
                response.EnsureSuccessStatusCode();
                var res = response.Content.ReadAsStringAsync().Result;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
                return string.Empty;
            }
        }

    }
}
