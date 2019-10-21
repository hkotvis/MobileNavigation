using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Navigation
{
    public class MainPageCS : TabbedPage
    {
        public MainPageCS()
        {
            var navigationPage = new NavigationPage(new SchedulePageCS());
           // navigationPage.IconImageSource = "schedule.png";
            navigationPage.Title = "Schedule";

            Children.Add(new TodayPageCS());
            Children.Add(navigationPage);
            Children.Add(new SettingsPage());
        }
    }

}
