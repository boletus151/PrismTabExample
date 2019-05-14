using System;
using Prism.Commands;
using Prism.Navigation;
using PrismTabExample.Views;

namespace PrismTabExample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.GoToFirstPageCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync(nameof(FirstPage)));
            this.GoToSecondPageCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync(nameof(SecondPage), null, true, true));

            this.GoForwardCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync(nameof(MainPage)));
            this.GoBackCommand = new DelegateCommand(() => this.NavigationService.GoBackAsync());
        }

        public DelegateCommand GoToFirstPageCommand { get; }
        public DelegateCommand GoToSecondPageCommand { get; }

        public DelegateCommand GoForwardCommand { get; }
        public DelegateCommand GoBackCommand { get; }

        public DelegateCommand GoToMainPageCommand { get; }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            var from = parameters.GetValue<bool>("fromMainPage");
            if (from)
            {
                this.NavigationService.NavigateAsync(nameof(Tab1Page));
            }
        }
    }
}
