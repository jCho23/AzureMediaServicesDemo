using Xamarin.Forms;
using AzureMediaServicesDemo.Constants;

namespace AzureMediaServicesSampleApp
{
	public class VideoWebViewPage : ContentPage
	{
		public VideoWebViewPage(string url)
		{
			Title = "Web View Video Player";

			Content = new WebView { Source = url };
		}
	}
}
