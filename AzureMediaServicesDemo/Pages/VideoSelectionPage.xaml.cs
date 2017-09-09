using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AzureMediaServicesDemo.Pages
{
    public partial class VideoSelectionPage : ContentPage
    {
        readonly Button webViewPageButton, nativeVideoPlayerButton;

        public VideoSelectionPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

			webViewPageButton.Clicked += HandleWebViewPageButtonClicked;
        }



        void HandleWebViewPageButtonClicked(object sender, System.EventArgs e)
        {
			Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(new VideoWebViewPage()));
		}

	}
}
