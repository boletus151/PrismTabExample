using Prism.Commands;
using Prism.Navigation;
using PrismTabExample.Views;

namespace PrismTabExample.ViewModels
{
    public class Tab1PageViewModel : ViewModelBase
    {
        public Tab1PageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.GoToPageCommand = new DelegateCommand(GoToPageCommandExecute);
        }

        public DelegateCommand GoToPageCommand { get; }

        private void GoToPageCommandExecute()
        {
            this.NavigationService.NavigateAsync(nameof(FirstPage),null,false,true);
        }
    }
}
