using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation
{
    public class TodayPageCS : ContentPage
    {
        public TodayPageCS()
        {
            var button = new Button
            {
                Text = "Go To Carousel Page",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += GoToCarousel;

            //IconImageSource = "today.png";
            
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Today's appointments go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                    button
                }
            };
        }
        private void GoToCarousel(object sender, EventArgs e)
        {
             Navigation.PushAsync(new MainCarouselPage());
        }
    }

}
