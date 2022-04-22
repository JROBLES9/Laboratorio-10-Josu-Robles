using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_10_Josué_Robles
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int edad()
        {
            return (DateTime.Now.Year - FechaNacimiento.Year);
        }
    }
}