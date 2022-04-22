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
        List<int> comodin = new List<int>();
        Alumno alumno = new Alumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            
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

        protected void ButtonCargar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            alumno.Nombre = TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Direccion = TextBoxDirección.Text;
            //alumno.FechaNacimiento = Calendar1. FECHA
            alumno.Carnee = TextBoxCarne.Text;
            Guardar();
        }

        protected void ButtonAnadirNota_Click(object sender, EventArgs e)
        {
            alumno.Notas.Add(Convert.ToInt32(TextBoxNota.Text));
        }
    }
}