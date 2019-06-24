using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class SettingsPageCS : ContentPage
	{
		public SettingsPageCS ()
		{
			IconImageSource = "settings.png";
			Title = "Settings";
			Content = new StackLayout {
				Children = {
					new Label {
						Text = "Settings go here",
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
