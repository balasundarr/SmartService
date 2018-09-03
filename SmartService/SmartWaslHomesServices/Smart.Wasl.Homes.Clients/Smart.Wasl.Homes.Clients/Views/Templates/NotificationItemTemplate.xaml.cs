﻿using System.Windows.Input;
using Xamarin.Forms;

namespace Smart.Wasl.Homes.Clients.Core.Views.Templates
{
    public partial class NotificationItemTemplate : ContentView
    {
        public static readonly BindableProperty TapCommandProperty =
            BindableProperty.Create("TapCommand", typeof(ICommand), typeof(NotificationItemTemplate));

        public ICommand TapCommand
        {
            get { return (ICommand)GetValue(TapCommandProperty); }
            set { SetValue(TapCommandProperty, value); }
        }

        public NotificationItemTemplate()
        {
            InitializeComponent();
        }
    }
}