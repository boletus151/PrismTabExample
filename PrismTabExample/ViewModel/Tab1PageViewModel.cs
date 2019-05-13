using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismTabExample.ViewModel
{
    public class FirstPageViewModel : BindableBase, INavigationAware
    {
        public FirstPageViewModel()
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
