using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class TestTwoCS : ContentPage
	{
		public TestTwoCS()
		{
			IconImageSource = "today.png";
			Title = "Today Two";
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
