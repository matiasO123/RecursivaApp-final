using CapaPresentacion.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Vistas
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        private void Socios_Load(object sender, EventArgs e)
        {
            AccesoDatos.ConexionGeneral cg = new AccesoDatos.ConexionGeneral();
            cg.DBCreator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SocioController socioController = new SocioController();
            RespuestaUnica ru = new RespuestaUnica("La cantidad de personas registradas es: "+ socioController.TotalSocios());
            ru.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SocioController socioController = new SocioController();
            RespuestaUnica ru = new RespuestaUnica("El promedio de edad de los socios de Racing es: " + socioController.PromEdadRacing() + " años");
            ru.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SocioController socioController = new SocioController();
            dataGridView1.DataSource = socioController.MenoresCasadosConUniversitario().Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; 
            SocioController socioController = new SocioController();
            dataGridView1.DataSource = socioController.NombresComunesRiver().Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; 
            SocioController socioController = new SocioController();
            dataGridView1.DataSource = socioController.EdadesXEquipo().Tables[0];
            dataGridView1.Columns["Promedio"].DefaultCellStyle.Format = "0.00";
        }
    }
}
