﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    public partial class TodayPage : ContentPage
    {
        public TodayPage()
        {
            InitializeComponent();
        }
        private void GoToCarousel(object sender, EventArgs e)
        {
           Navigation.PushAsync(new MainCarouselPage());
        }
    }
}