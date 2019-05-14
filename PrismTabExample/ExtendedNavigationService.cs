using System;
using System.Threading.Tasks;
using Prism.Navigation;

namespace PrismTabExample
{
    public class ExtendedNavigationService : IExtendedNavigationService
    {
        public ExtendedNavigationService(INavigationService navigationService)
        {
            this.baseNavService = navigationService;
        }

        public INavigationService baseNavService { get; }

        public void GoToRoot()
        {
            //this.baseNavService.
        }
    }
}
