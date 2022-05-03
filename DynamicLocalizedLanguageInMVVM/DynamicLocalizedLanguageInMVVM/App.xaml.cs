

using DynamicLocalizedLanguageInMVVM.ViewModels;
using DynamicLocalizedLanguageInMVVM.Views;
using Prism.Ioc;

namespace DynamicLocalizedLanguageInMVVM
{
    public partial class App 
    {
        public App()
        {   
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
