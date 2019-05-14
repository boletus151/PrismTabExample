using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismTabExample.Views;

namespace PrismTabExample.ViewModels
{
    public class FirstPageViewModel : BindableBase
    {
        public FirstPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.GoToPageCommand = new DelegateCommand(GoToCommandExecute);
        }

        public DelegateCommand GoToPageCommand { get; }

        private void GoToCommandExecute()
        {
            this.NavigationService.NavigateAsync(nameof(SecondPage), null, true, true);
        }
    }
}
