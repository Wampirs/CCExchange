using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace CCExchange.ViewModels
{
    public class ExchangesVm : ViewModel
    {
        private IApiService api;

        private List<Exchange> exchanges;

        private List<Exchange> filteredExchanges;
        public List<Exchange> FilteredExchanges
        {
            get => filteredExchanges;
            set
            {
                Set(ref filteredExchanges, value);
                SelectedExchange = filteredExchanges.FirstOrDefault();
            }
        }

        private Exchange selectedExchange;
        public Exchange SelectedExchange
        {
            get => selectedExchange;
            set
            {
                Set(ref selectedExchange, value);
                if (value == null)
                {
                    InfoVM = null;
                    return;
                }
                InfoVM = new ExchangeInfoVM(value);
            }
        }

        private string searchCriteria = string.Empty;
        public string SearchCriteria
        {
            get { return searchCriteria; }
            set
            {
                Set(ref searchCriteria, value);
                if (FilterChanged != null) FilterChanged();
            }
        }


        private ExchangeInfoVM infoVM;
        public ExchangeInfoVM InfoVM
        {
            get { return infoVM; }
            set { Set(ref infoVM, value); }
        }

        public ExchangesVm()
        {
            api = App.Services.GetRequiredService<IApiService>();
            exchanges = api.GetExchanges();
            FilterChanged += OnFilterChanged;
            if (FilterChanged != null) FilterChanged();
        }

        private void OnFilterChanged()
        {
            if (SearchCriteria == string.Empty)
            {
                FilteredExchanges = exchanges;
                return;
            }
            FilteredExchanges = exchanges.Where(x => x.Name.ToLower().Contains(SearchCriteria.ToLower())).ToList();
        }

        private delegate void FilterChangedHandler();
        private FilterChangedHandler FilterChanged;
    }
}
