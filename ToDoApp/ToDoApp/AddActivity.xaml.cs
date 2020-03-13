using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddActivity : ContentPage
    {
        public AddActivity()
        {
            InitializeComponent();
        }

        public async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }
    }
}