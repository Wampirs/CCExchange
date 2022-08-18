using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCExchange.ViewModels
{
    public class MainWindowVM : ViewModel
    {
        private readonly IApiService api;

        public MainWindowVM(IApiService _api)
        {
            api = _api;
        }
        public List<Currency> Curs => api.GetCurrenciesAsync().Result;

    }
}
