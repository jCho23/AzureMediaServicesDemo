using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AzureMediaServicesDemo.Pages
{
    public partial class VideoSelectionPage : ContentPage
    {
        public VideoSelectionPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

		void HandleWebViewPageButtonClicked(object sender, EventArgs e) =>
			Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(new VideoWebViewPage()));

	}
}
