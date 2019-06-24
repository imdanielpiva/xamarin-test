using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class MainPageCS : TabbedPage
	{
		public MainPageCS ()
		{
			var navigationPage = new NavigationPage (new SchedulePageCS ());
			navigationPage.IconImageSource = "schedule.png";
			navigationPage.Title = "Schedule";

            Children.Add(new TestOneCS());
            Children.Add(new TestTwoCS());
            Children.Add(new TestThreeCS());
            Children.Add (new TodayPageCS ());
			Children.Add (navigationPage);
			Children.Add (new SettingsPage ());
        }
	}
}
