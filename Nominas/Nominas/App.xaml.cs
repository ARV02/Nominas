using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nominas
{
    public partial class App : Application
    {
        public static Conexion DB;
        public App()
        {
            InitializeComponent();
            String basedatos = "Empleados.db3";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var dbPath = System.IO.Path.Combine(docPath, basedatos);
            DB = new Conexion(dbPath);
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
