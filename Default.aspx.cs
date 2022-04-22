using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_10_Josué_Robles
{
    public partial class _Default : Page
    {
        List<Alumno> Alumnos = new List<Alumno>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Cargar();
            Guardar();
        }

        private void Cargar()
        {
            string archivo = Server.MapPath("Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            Alumnos = JsonConvert.DeserializeObject<List<Alumno>>(json);
        }

        private void Guardar()
        {
            string json = JsonConvert.SerializeObject(Alumnos);
            string archivo = Server.MapPath("Datos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}