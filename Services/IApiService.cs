using CCExchange.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCExchange.Services
{
    public interface IApiService
    {
        public Task<List<Currency>> GetCurrenciesAsync(int count = -1);
        public Task<Currency> GetCurrencyAsync(string id);
    }
}