﻿using CCExchange.Commands;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using System.Windows.Input;

namespace CCExchange.ViewModels
{
    public class MainWindowVM : ViewModel
    {

        private ViewModel curVm;
        public ViewModel CurrentVm
        {
            get { return curVm; }
            private set { Set(ref curVm, value); }
        }

        public MainWindowVM()
        {
            CurrentVm = new TopCurrencyVM();
        }

        #region ShowTopCommand
        private ICommand showTopCommand;
        public ICommand ShowTopCommand => showTopCommand ??= new RelayCommand(OnShowTopExecuted, CanShowTopExetute);
        private void OnShowTopExecuted(object o)
        {
            if (CurrentVm.GetType() == typeof(TopCurrencyVM)) return;
            CurrentVm = new TopCurrencyVM();
        }
        private bool CanShowTopExetute(object o) => CurrentVm.GetType() != typeof(TopCurrencyVM);

        #endregion
        #region ShowDetailCommand
        private ICommand showdetailCommand;
        public ICommand ShowDetailCommand => showdetailCommand ??= new RelayCommand(OnShowDetailExecuted, CanShowDetailExetute);
        private void OnShowDetailExecuted(object o)
        {
            if (CurrentVm.GetType() == typeof(DetailInfoVM)) return;
            CurrentVm = new DetailInfoVM();
        }
        private bool CanShowDetailExetute(object o) => CurrentVm.GetType() != typeof(DetailInfoVM);

        #endregion
    }
}
