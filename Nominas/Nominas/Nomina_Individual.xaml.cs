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
    public partial class Nomina_Individual : ContentPage
    {
        public Nomina_Individual()
        {
            InitializeComponent();
        }

        private void Buscar_Clicked(object sender, EventArgs e)
        {
            Persona encontrado = App.DB.GetPersona(CNombre.Text, CApellido.Text);
            try
            {
                int id = encontrado.Id;
                String nombre = encontrado.Nombre.ToString();
                String apellido = encontrado.Apellido.ToString();
                double sueldo = Convert.ToDouble(encontrado.Sueldo.ToString());
                DisplayAlert("Encontrado", "ID: " + id + "\nNombre: " + nombre + "\nApellido: " + apellido +
                    "\nSueldo: " + sueldo, "Aceptar");
            }
            catch
            {
                DisplayAlert("Error ", "No se ha encontrado", "Aceptar");
            }
        }
    }
}