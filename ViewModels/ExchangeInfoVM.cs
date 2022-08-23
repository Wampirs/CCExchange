using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;

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

    }
}
