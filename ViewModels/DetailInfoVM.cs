using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCExchange.ViewModels
{
    public class DetailInfoVM : ViewModel
    {
        private IApiService api;
        public CurrencyInfoVM CurrencyInfoVM { get; private set; }
        private List<Currency> currencies;
        public List<Currency> Currencies
        {
            get => currencies;
            set => Set(ref currencies, value);
        }

        private Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get => selectedCurrency;
            set => Set(ref selectedCurrency, value);
        }


        public DetailInfoVM()
        {
            api = App.Services.GetRequiredService<IApiService>();
            CurrencyInfoVM = new CurrencyInfoVM();
            Currencies = api.GetCurrenciesAsync().Result;
            SelectedCurrency = Currencies[0];
        }
    }
}
