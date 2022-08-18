using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCExchange.ViewModels
{
    public class TopCurrencyVM : ViewModel
    {
        private readonly IApiService api;
        private ObservableCollection<Currency> curs;
        public ObservableCollection<Currency> Curs 
        {
            get { return curs; } 
            private set { Set(ref curs, value); }
        }

        public TopCurrencyVM()
        {
            api = App.Services.GetRequiredService<IApiService>();
            Curs = new ObservableCollection<Currency>(api.GetCurrenciesAsync().Result.GetRange(0,10));
        }
    }
}
