using System;
using System.Collections.Generic;
using AzureMediaServicesSampleApp;
using Xamarin.Forms;

namespace AzureMediaServicesDemo.Pages
{
    public partial class VideoSelectionPage : ContentPage
    {
        
        public VideoSelectionPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }


        void HandleWebViewPageButtonClicked(object sender, System.EventArgs e)
        {
			Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(new VideoWebViewPage()));
		}

	}
}
