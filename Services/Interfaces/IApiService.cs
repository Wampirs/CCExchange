﻿using CCExchange.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCExchange.Services
{
    public interface IApiService
    {
        public List<Currency> GetCurrenciesAsync(int count = -1);
        public Currency GetCurrencyAsync(string id);
        public List<Market> GetMarketsAsync(string curId);
    }
}