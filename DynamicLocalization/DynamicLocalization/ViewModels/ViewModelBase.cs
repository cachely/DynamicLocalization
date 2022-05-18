using DynamicLocalization.Messages;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using Xamarin.Forms;

namespace DynamicLocalization.ViewModels
{
    internal class ViewModelBase : BindableBase, INavigationAware, IDisposable
    {
        public ViewModelBase(INavigationService navigationService) 
        {
            NavigationService = navigationService;
        }

        public INavigationService NavigationService { get; set; }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
           
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            MessagingCenter.Subscribe<UpdateLocalizedItems>(this, string.Empty, (args) => UpdateLocalizedItems());
            UpdateLocalizedItems();
        }

        protected virtual void UpdateLocalizedItems()
        {
        }

        public virtual void Dispose()
        {
            MessagingCenter.Unsubscribe<UpdateLocalizedItems>(this, string.Empty);
        }
    }
}
