using DynamicLocalization.Utilities;
using Prism.Mvvm;
using Prism.Navigation;

namespace DynamicLocalization.ViewModels
{
    internal class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _greeting;
        private string _instructions;

        public string Greeting
        {
            get => _greeting;
            set
            {
                _greeting = value;
                RaisePropertyChanged(nameof(Greeting));
            }
        }

        public string Instructions
        {
            get => _instructions;
            set
            {
                _instructions = value;
                RaisePropertyChanged(nameof(Greeting));
            }
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }

        public void UpdateLocalizedItems()
        {
            Greeting = DynamicLocalizer.GetText("Hello");
            Instructions = DynamicLocalizer.GetText("Instructions");
        }
    }
}
