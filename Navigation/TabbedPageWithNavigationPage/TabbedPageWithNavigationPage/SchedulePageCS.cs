using System;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class SchedulePageCS : ContentPage
	{
		public SchedulePageCS ()
		{
			var button = new Button {
				Text = "Upcoming Appointments",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += OnUpcomingAppointmentsButtonClicked;

			Title = "This Week";
			Content = new StackLayout {
				Children = {
					new Label {
						Text = "This week's appointments go here",
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

		async void OnUpcomingAppointmentsButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new UpcomingAppointmentsPage ());
		}
	}
}
