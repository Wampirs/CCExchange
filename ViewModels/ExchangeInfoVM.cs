using CCExchange.Commands;
using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using CCExchange.Views.Windows;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace CCExchange.ViewModels
{
    public class ExchangeInfoVM : ViewModel
    {
        private readonly IApiService api;

        private Exchange exchange;
        public Exchange Exchange
        {
            get { return exchange; }
            set { Set(ref exchange, value); }
        }

        public ExchangeInfoVM(Exchange exch)
        {
            api = App.Services.GetRequiredService<IApiService>();
            Exchange = api.GetExchangeById(exch.ExchangeId);
        }

        private ICommand openSite;
        public ICommand OpenSiteCommand => openSite ??= new RelayCommand(OnOpenSiteExecuted, CanOpenSiteExecute);
        private void OnOpenSiteExecuted(object o)
        {
            System.Diagnostics.Process.Start("explorer",$"{Exchange.ExchangeUrl}");
        }
        private bool CanOpenSiteExecute(object o) => Exchange.ExchangeUrl != null;

    }
}
