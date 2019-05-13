using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismTabExample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }
    }
}
