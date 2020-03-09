using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var time = DateTime.Now;
            int hour = time.Hour;

            if (hour < 11)
            {
                MainPage = new NavigationPage(new MidDay());
            }
            else
            {
                MainPage = hour < 14 ? new NavigationPage(new Noon()) : new NavigationPage(new Night());
            }
        }

        protected override void OnStart()
        {
            var time = DateTime.Now;
            int hour = time.Hour;

            if (hour < 11)
            {
                MainPage = new NavigationPage(new MidDay()); 
            }
            else
            {
                MainPage = hour < 14 ? new NavigationPage(new Noon()) : new NavigationPage(new Night());
            }
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
