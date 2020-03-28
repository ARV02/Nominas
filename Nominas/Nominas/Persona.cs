using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Nominas
{
    [Table("Persona")]
    public class Persona
    {
        [PrimaryKey,AutoIncrement]
        public int Id { set; get; }
        public String Nombre { set; get; }
        public String Apellido { set; get; }
        public double Sueldo { set; get; }
    }
}
