using DynamicLocalization.Utilities;
using Prism.Navigation;
using Xamarin.Forms;

namespace DynamicLocalization.ViewModels
{
    internal class MainPageViewModel : ViewModelBase
    {
        private string _greeting;
        private string _instructions;

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public string Greeting
        {
            get => _greeting;
            set => SetProperty(ref _greeting, value, nameof(Greeting));
        }

        public string Instructions
        {
            get => _instructions;
            set => SetProperty(ref _instructions, value, nameof(Instructions));
        }

        public Command UpdateCommand
        {
            get
            {
                return new Command(() => Settings.FlipCulture());
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            UpdateLocalizedItems();
            base.OnNavigatedTo(parameters);
        }

        protected override void UpdateLocalizedItems()
        {
            Greeting = DynamicLocalizer.GetText("Hello");
            Instructions = DynamicLocalizer.GetText("Instructions");
            base.UpdateLocalizedItems();
        }
    }
}
