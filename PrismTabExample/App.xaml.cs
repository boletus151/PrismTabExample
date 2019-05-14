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

        public App(IPlatformInitializer initializer) : base(initializer)
        {
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("/MyTabbedPage?selectedTab=Tab1Page");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<MyTabbedPage>();
            containerRegistry.RegisterForNavigation<Tab1Page, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Tab2Page, MainPageViewModel>();

            containerRegistry.RegisterForNavigation<FirstPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<SecondPage, MainPageViewModel>();

            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            containerRegistry.RegisterForNavigation<Tab2Page, ModalViewModel>();
            containerRegistry.RegisterForNavigation<Modal2Page, ModalViewModel>();
            containerRegistry.RegisterForNavigation<Modal3Page, ModalViewModel>();
            containerRegistry.RegisterForNavigation<Modal4Page, ModalViewModel>();
        }
    }
}
