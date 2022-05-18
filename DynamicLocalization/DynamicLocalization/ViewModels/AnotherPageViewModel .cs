using DynamicLocalization.Utilities;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace DynamicLocalization.ViewModels
{
    internal class AnotherPageViewModel : ViewModelBase
    {
        private string _dialog;
        private string _goBack;

        public AnotherPageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }

        public string Dialog
        {
            get => _dialog;
            set
            {
                _dialog = value;
                RaisePropertyChanged(nameof(Dialog));
            }
        }

        public string GoBack
        {
            get => _goBack;
            set
            {
                _goBack = value;
                RaisePropertyChanged(nameof(GoBack));
            }
        }

        public Command NavigateBack
        {
            get => new Command(() => NavigationService.GoBackAsync());
        }

        protected override void UpdateLocalizedItems()
        {
            Dialog = DynamicLocalizer.GetText("Dialog");
            GoBack = DynamicLocalizer.GetText("GoBack");
        }
    }
}
