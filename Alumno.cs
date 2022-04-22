using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_10_Josué_Robles
{
    public class Alumno : Persona
    {
        public int Carnee { get; set; }
        public List<int> Notas { get; set; }
    }
}