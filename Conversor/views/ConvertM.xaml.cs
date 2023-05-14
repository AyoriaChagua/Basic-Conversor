using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConvertM : ContentPage
	{

		double cm;
		double m;

		public ConvertM ()
		{
			InitializeComponent ();
		}

		private void CalculateCm() 
		{ 
			cm = Convert.ToDouble(TxtCm.Text); //Para modificar el tipo de dato simplemente debemos usar la clase Convert
			m = cm / 100;
            LblResult.Text = $"{m.ToString()} m";

        }

		private void Validate() 
		{
			if (!string.IsNullOrEmpty(TxtCm.Text))
			{
				CalculateCm();
			}
			else 
			{
				DisplayAlert("Error", "Enter an amount", "OK");	
			}
		}

        private async void BtnReturn_Clicked(object sender, EventArgs e)
        {
			await Navigation.PopAsync();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
			Validate();
        }
    }
}