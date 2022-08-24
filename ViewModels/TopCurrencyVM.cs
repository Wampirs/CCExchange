using CCExchange.Commands;
using CCExchange.Models;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Windows.Input;

namespace CCExchange.ViewModels
{
    public class TopCurrencyVM : ViewModel
    {
        private readonly IApiService api;
        private readonly IDialogService dialog;

        private List<Currency> curs;
        public List<Currency> Curs
        {
            get { return curs; }
            private set { Set(ref curs, value); }
        }

        public TopCurrencyVM()
        {
            api = App.Services.GetRequiredService<IApiService>();
            dialog = App.Services.GetRequiredService<IDialogService>();
            Curs = api.GetCurrencies(10);
        }

        #region Refresh command
        private ICommand refreshCommand;
        public ICommand RefreshCommand => refreshCommand ??= new RelayCommand(OnRefreshExecuted, CanRefreshExecute);
        private void OnRefreshExecuted(object o)
        {
            Curs = api.GetCurrencies(10);
        }
        private bool CanRefreshExecute(object o) => true;
        #endregion

        #region Show info dialog
        private ICommand showInfoDialog;
        public ICommand ShowInfoDialogCommand => showInfoDialog ??= new RelayCommand(OnshowInfoDialogExecuted, CanshowInfoDialogExecute);
        private void OnshowInfoDialogExecuted(object o)
        {
            dialog.ShowDialog(new CurrencyInfoVM(o as Currency));
        }
        private bool CanshowInfoDialogExecute(object o) => true; 
        #endregion
    }
}
