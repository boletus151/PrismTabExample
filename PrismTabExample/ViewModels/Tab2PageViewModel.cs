using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismTabExample.ViewModels
{
    public class Tab2PageViewModel : ViewModelBase
    {
        public Tab2PageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
