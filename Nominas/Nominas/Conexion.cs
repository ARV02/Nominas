using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
namespace Nominas
{
    public class Conexion : SQLiteConnection
    {
        public Conexion(string path) : base(path)
        {
            Initialize();
        }
        void Initialize()
        {
            CreateTable<Persona>();
        }
        public Persona GetPersona(string nombre)
        {
            try
            {
                return Table<Persona>().Where(t => t.Nombre == nombre).First();
            }catch
            {
                Persona vacio = new Persona();
                return vacio;
            }
        }
        public Persona GetPersona(string nombre, string apellido)
        {
            try
            {
                return Table<Persona>().Where(t => t.Nombre == nombre).Where(t => t.Apellido == apellido).First();
            }
            catch
            {
                Persona vacio = new Persona();
                return vacio;
            }
        }
            public int Registra(Persona persona)
        {
            return Insert(persona);
        }
        public int Total(Persona persona)
        {
            return Table<Persona>().Count();
        }
    }
}
