using Android.Content;
using Android.Support.Design.Widget;
using PrismTabExample.Droid.Renders;
using PrismTabExample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

//[assembly: ExportRenderer(typeof(MyTabbedPage), typeof(MyTabbedPageRenderer))]
namespace PrismTabExample.Droid.Renders
{
    public class MyTabbedPageRendererUpperTabBar : TabbedPageRenderer, TabLayout.IOnTabSelectedListener
    {
        private MyTabbedPage _page;

        public MyTabbedPageRendererUpperTabBar(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                _page = (MyTabbedPage)e.NewElement;
            }
            else
            {
                _page = (MyTabbedPage)e.OldElement;
            }

        }

        async void TabLayout.IOnTabSelectedListener.OnTabReselected(TabLayout.Tab tab)
        {
            await _page.CurrentPage.Navigation.PopToRootAsync();
        }
    }
}