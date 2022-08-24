using CCExchange.Commands;
using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Windows.Input;

namespace CCExchange.ViewModels
{
    public class CurrencyInfoVM : ViewModel
    {
		private readonly IApiService api;
		private readonly IDialogService dialog;

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
			dialog = App.Services.GetRequiredService<IDialogService>();
			Currency = api.GetCurrencyById(curr.Id);
			Markets = api.GetMarketsByID(curr.Id);
		}

        private ICommand showInfoDialog;
        public ICommand ShowInfoDialogCommand => showInfoDialog ??= new RelayCommand(OnshowInfoDialogExecuted, CanshowInfoDialogExecute);
        private void OnshowInfoDialogExecuted(object o)
        {
            dialog.ShowDialog(new ExchangeInfoVM(api.GetExchangeById(o as string)));
        }
        private bool CanshowInfoDialogExecute(object o) => true;

    }
}
