﻿using Smart.Wasl.Homes.Clients.Core.Helpers;
using Xamarin.Forms;

namespace Smart.Wasl.Homes.Clients.Core.Views
{
    public partial class BookingView : ContentPage
    {
        public BookingView()
        {
            if (Device.RuntimePlatform != Device.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            NavigationPage.SetBackButtonTitle(this, string.Empty);

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(true);
        }
    }
}