using System;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismTabExample.ViewModels
{
    public class ViewModelBase : BindableBase, IInitializeAsync
    {
        public INavigationService NavigationService { get; set; }

        public ViewModelBase(INavigationService navigationService)
        {
            this.NavigationService = navigationService;
        }

        public virtual Task InitializeAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }
    }
}
