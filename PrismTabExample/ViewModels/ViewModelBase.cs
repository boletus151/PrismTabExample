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

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }
    }
}
