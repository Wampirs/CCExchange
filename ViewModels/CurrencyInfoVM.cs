using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace CCExchange.ViewModels
{
    public class CurrencyInfoVM : ViewModel
    {
		private readonly IApiService api;

		private Currency currency;
		public Currency Currency
		{
			get { return currency; }
			set { Set(ref currency,value); }
		}

		private List<Market> markets;

		public List<Market> Markets
		{
			get { return markets; }
			set { Set(ref markets, value); }
		}



		public CurrencyInfoVM(Currency curr)
		{
			api = App.Services.GetRequiredService<IApiService>();
			Currency = api.GetCurrencyAsync(curr.Id);
			Markets = api.GetMarketsAsync(curr.Id);
		}

	}
}
