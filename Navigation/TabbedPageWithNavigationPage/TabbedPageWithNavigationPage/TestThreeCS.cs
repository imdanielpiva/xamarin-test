using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class TestThreeCS : ContentPage
	{
		public TestThreeCS()
		{
			IconImageSource = "today.png";
			Title = "Today Three";
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
