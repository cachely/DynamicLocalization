using DynamicLocalization.Utilities;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace DynamicLocalization.ViewModels
{
    internal class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _greeting;
        private string _instructions;
        private Command _updateCommand;

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

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            UpdateLocalizedItems();
        }

        public void UpdateLocalizedItems()
        {
            Greeting = DynamicLocalizer.GetText("Hello");
            Instructions = DynamicLocalizer.GetText("Instructions");
        }
    }
}
