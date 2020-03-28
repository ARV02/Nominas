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
    public partial class Registrar : ContentPage
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Guardar_Clicked(object sender, EventArgs e)
        {
            Persona encontrado = App.DB.GetPersona(Nombre.Text, Apellido.Text);
            if (!string.IsNullOrEmpty(Nombre.Text) && !string.IsNullOrEmpty(Apellido.Text) &&
                !string.IsNullOrEmpty(Sueldo.Text))
            {
                Persona persona = new Persona();
                try
                {
                    String nombre = encontrado.Nombre.ToString();
                    String apellido = encontrado.Apellido.ToString();
                    if (nombre == Nombre.Text && apellido == Apellido.Text)
                    {
                        DisplayAlert("Error", "El usuario ya existe", "Aceptar");
                    }
                }
                catch
                {
                    persona.Nombre = Nombre.Text;
                    persona.Apellido = Apellido.Text;
                    persona.Sueldo = Convert.ToDouble(Sueldo.Text);
                    App.DB.Registra(persona);
                    DisplayAlert("Registrado", "Registro exitoso", "Aceptar");
                }
            }
            else
            {
                DisplayAlert("Error", "Uno de los campos esta vacio", "Aceptar");
            }
        }
    }
}