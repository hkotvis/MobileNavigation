﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation
{
    public class UpcomingAppointmentsPageCS : ContentPage
    {
        public UpcomingAppointmentsPageCS()
        {
            var button = new Button
            {
                Text = "Back",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnBackButtonClicked;

            Title = "Upcoming";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Upcoming appointments go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    button
                }
            };
        }

        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
