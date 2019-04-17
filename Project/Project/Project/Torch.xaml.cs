using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Xamarin.Forms;
using Lamp.Plugin;

namespace Project
{
	
	public partial class Torch : ContentPage
	{
		public Torch ()
		{
			InitializeComponent ();
		}

        private void Switch_OnToggled(object sender, ToggledEventArgs e)
        {

            if (e.Value == true)
            {
                CrossLamp.Current.TurnOn();
                label.Text = "Flash Light is On ";
            }

            else
            {
                CrossLamp.Current.TurnOff();
                label.Text = "Flash Light is Off ";
            }
        }
    }
}