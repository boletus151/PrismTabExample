using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismTabExample.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        public INavigationService NavigationService { get; set; }

        public ViewModelBase(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
        }
    }
}
