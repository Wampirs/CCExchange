﻿using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace CCExchange.ViewModels
{
    public class DetailInfoVM : ViewModel
    {
        private IApiService api;

        private List<Currency> currencies;

        private List<Currency> filteredCurrencies;
        public List<Currency> FilteredCurrencies
        {
            get => filteredCurrencies;
            set
            {
                Set(ref filteredCurrencies, value);
                SelectedCurrency = filteredCurrencies.FirstOrDefault();
            }
        }

        private Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get => selectedCurrency;
            set
            {
                Set(ref selectedCurrency, value);
                if (value == null)
                {
                    InfoVM = null;
                    return;
                }
                InfoVM = new CurrencyInfoVM(value);
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

        private CurrencyInfoVM infoVM;
        public CurrencyInfoVM InfoVM
        {
            get { return infoVM; }
            set { Set(ref infoVM, value); }
        }

        public DetailInfoVM()
        {
            api = App.Services.GetRequiredService<IApiService>();
            currencies = api.GetCurrencies();
            FilterChanged += OnFilterChanged;
            if (FilterChanged != null) FilterChanged();
        }

        private void OnFilterChanged()
        {
            if (SearchCriteria == string.Empty)
            {
                FilteredCurrencies = currencies;
                return;
            }
            FilteredCurrencies = currencies.Where(x => x.Name.ToLower().Contains(SearchCriteria.ToLower()) || x.Symbol.ToLower().Contains(SearchCriteria.ToLower())).ToList();
        }

        private delegate void FilterChangedHandler();
        private FilterChangedHandler FilterChanged;
    }
}
