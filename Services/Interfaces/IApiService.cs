using CCExchange.Models;
using System.Collections.Generic;

namespace CCExchange.Services
{
    public interface IApiService
    {
        public List<Currency> GetCurrencies(int count = -1);
        public Currency GetCurrencyById(string id);
        public List<Market> GetMarketsByID(string curId);
        public List<Exchange> GetExchanges();
        public Exchange GetExchangeById(string exId);
    }
}