using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nominas
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

        protected async void Registrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrar());
        }

        protected async void NominaI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nomina_Individual());
        }

        protected async void NominaT_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Nomina_Total());
        }
    }
}
