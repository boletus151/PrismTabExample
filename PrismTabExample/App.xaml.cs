using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismTabExample.ViewModels;
using PrismTabExample.Views;
using Xamarin.Forms;
using System;

namespace PrismTabExample
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer): base(initializer)
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("/NavigationPage/MyTabbedPage?selectedTab=Tab1Page");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<MyTabbedPage>();
            containerRegistry.RegisterForNavigation<Tab1Page, Tab1PageViewModel>();
            containerRegistry.RegisterForNavigation<Tab2Page, Tab2PageViewModel>();

            containerRegistry.RegisterForNavigation<FirstPage, FirstPageViewModel>();
            containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>();

            containerRegistry.RegisterForNavigation<MainPage>();
        }
    }
}
