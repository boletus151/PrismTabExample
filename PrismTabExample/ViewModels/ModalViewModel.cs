using System;
using Prism.Commands;
using Prism.Navigation;
using PrismTabExample.Views;

namespace PrismTabExample.ViewModels
{
    public class ModalViewModel : ViewModelBase
    {
        public ModalViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.Modal2Command = new DelegateCommand(() => this.NavigationService.NavigateAsync($"NavigationPage/{nameof(Modal2Page)}", null, true, false));
            this.Modal3Command = new DelegateCommand(() => this.NavigationService.NavigateAsync(nameof(Modal3Page)));
            this.Modal4Command = new DelegateCommand(() => this.NavigationService.NavigateAsync(nameof(Modal4Page)));

            //this.GoBackCommand = new DelegateCommand(() => this.NavigationService.GoBackAsync(new NavigationParameters { { "fromModal4", true } }));
            this.GoBackCommand = new DelegateCommand(() => this.NavigationService.NavigateAsync($"/{nameof(MyTabbedPage)}?selectedTab={nameof(Tab1Page)}"));
            this.CancelCommand = new DelegateCommand(this.CancelCommandExectue);
        }

        private void CancelCommandExectue()
        {
            this.NavigationService.NavigateAsync($"/{nameof(MyTabbedPage)}?selectedTab={nameof(Tab2Page)}");
        }

        public DelegateCommand Modal2Command { get; }

        public DelegateCommand Modal3Command { get; }

        public DelegateCommand GoBackCommand { get; }

        public DelegateCommand Modal4Command { get; }

        public DelegateCommand CancelCommand { get; }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            var from = parameters.GetValue<bool>("fromModal4");
            if (from)
            {
                this.NavigationService.GoBackAsync(new NavigationParameters { { "fromModal3", true } });
            }
            from = parameters.GetValue<bool>("fromModal3");
            if (from)
            {
                this.NavigationService.GoBackAsync(new NavigationParameters { { "fromModal2", true } });
            }
            from = parameters.GetValue<bool>("fromModal2");
            if (from)
            {
                this.NavigationService.GoBackAsync(new NavigationParameters { { "fromModal1", true } });
            }
            from = parameters.GetValue<bool>("fromModal1");
            if (from)
            {
                this.NavigationService.NavigateAsync($"{nameof(Tab1Page)}?selectedTab=Tab1Page");
            }
        }
    }
}

