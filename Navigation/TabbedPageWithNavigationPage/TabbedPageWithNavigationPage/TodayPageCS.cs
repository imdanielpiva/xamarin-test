using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class TodayPageCS : ContentPage
	{
		public TodayPageCS ()
		{
			IconImageSource = "today.png";
			Title = "Today";
			Content = new StackLayout {
				Children = {
					new Label {
						Text = "Today's appointments go here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					},
					new WebView
					{
							WidthRequest = 375,
							HeightRequest = 1000,
							Source = "https://google.com"
					}
				}
			};
		}
	}
}
