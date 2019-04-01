using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Money_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MoneyPage());
        }

        private void Time_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TimePage());
        }

        private void Speed_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SpeedPage());
        }

        private void Temperture_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TempPage());
        }

        private void Distance_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DistancePage());
        }
    }
}
