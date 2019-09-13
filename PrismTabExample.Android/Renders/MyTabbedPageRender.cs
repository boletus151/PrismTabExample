using Android.Content;
using Android.Support.Design.Widget;
using Android.Views;
using PrismTabExample.Droid.Renders;
using PrismTabExample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(MyTabbedPage), typeof(MyTabbedPageRenderer))]
namespace PrismTabExample.Droid.Renders
{
    public class MyTabbedPageRenderer : TabbedPageRenderer, BottomNavigationView.IOnNavigationItemReselectedListener
    {
        private MyTabbedPage _page;

        public MyTabbedPageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null && e.NewElement != null)
            {
                _page = (MyTabbedPage)e.NewElement;

                for (int i = 0; i <= this.ViewGroup.ChildCount - 1; i++)
                {
                    var childView = this.ViewGroup.GetChildAt(i);
                    if (childView is ViewGroup viewGroup)
                    {
                        for (int j = 0; j <= viewGroup.ChildCount - 1; j++)
                        {
                            var childRelativeLayoutView = viewGroup.GetChildAt(j);
                            if (childRelativeLayoutView is BottomNavigationView bottomNavigationView)
                            {
                                bottomNavigationView.SetOnNavigationItemReselectedListener(this);
                            }
                        }
                    }
                }
            }
        }

        public async void OnNavigationItemReselected(IMenuItem item)
        {
            await _page?.CurrentPage?.Navigation?.PopToRootAsync();
        }
    }
}