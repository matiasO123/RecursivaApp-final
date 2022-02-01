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
    public partial class RespuestaUnica : Form
    {
        public RespuestaUnica(string respuesta)
        {
            InitializeComponent();
            label1.Text = respuesta;
        }

        private void RespuestaUnica_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
