using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TakeMeTo_MidDay(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MidDay());
        }

        private void TakeMeTo_Noon(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Noon());
        }

        private void TakeMeTo_Night(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Night());
        }
        private void Add_Activity(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddActivity());
        }
        
        
    }
}
