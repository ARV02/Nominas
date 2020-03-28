using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nominas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nomina_Total : ContentPage
    {
        public Nomina_Total()
        {
            InitializeComponent();
        }

        private void ConsultaT_Clicked(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            var ent = App.DB.ExecuteScalar<double>("SELECT SUM(Sueldo) FROM Persona WHERE Sueldo > 0");
            DisplayAlert("Total de personas: " + App.DB.Total(persona) + "\nSueldo Total: ", ent.ToString(), "Aceptar");

        }
    }
}