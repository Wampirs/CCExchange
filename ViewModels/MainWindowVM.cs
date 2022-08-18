using CCExchange.Commands;
using CCExchange.Services;
using CCExchange.ViewModels.Base;
using System.Windows.Input;

namespace CCExchange.ViewModels
{
    public class MainWindowVM : ViewModel
    {
        private TopCurrencyVM topVm;
        private DetailInfoVM detailVM;

        private ViewModel curVm;
        public ViewModel CurrentVm
        {
            get { return curVm; }
            private set { Set(ref curVm, value); }
        }

        public MainWindowVM()
        {
            topVm = new TopCurrencyVM();
            detailVM = new DetailInfoVM();
            CurrentVm = topVm;
        }

        #region ShowTopCommand
        private ICommand showTopCommand;
        public ICommand ShowTopCommand => showTopCommand ??= new RelayCommand(OnShowTopExecuted, CanShowTopExetute);
        private void OnShowTopExecuted(object o)
        {
            if (CurrentVm == topVm) return;
            CurrentVm = topVm;
        }
        private bool CanShowTopExetute(object o) => CurrentVm != topVm;

        #endregion
        #region ShowDetailCommand
        private ICommand showdetailCommand;
        public ICommand ShowDetailCommand => showdetailCommand ??= new RelayCommand(OnShowDetailExecuted, CanShowDetailExetute);
        private void OnShowDetailExecuted(object o)
        {
            if (CurrentVm == detailVM) return;
            CurrentVm = detailVM;
        }
        private bool CanShowDetailExetute(object o) => CurrentVm != detailVM;

        #endregion
    }
}
