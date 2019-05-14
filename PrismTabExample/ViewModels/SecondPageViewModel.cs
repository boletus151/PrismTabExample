using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismTabExample.Views;

namespace PrismTabExample.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.GoToPageCommand = new DelegateCommand(async ()=> await GoToCommandExecute());
        }

        public DelegateCommand GoToPageCommand { get; }

        private async Task GoToCommandExecute()
        {
            await this.NavigationService.GoBackAsync();
            await this.NavigationService.NavigateAsync(nameof(SecondPage), null, true, true);
        }
    }
}
