using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation
{

    public class MainCarouselPageCS : ContentPage
    {
        public MainCarouselPageCS()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "I Am Page 1",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    }
                }
            };
        }
    }
}
