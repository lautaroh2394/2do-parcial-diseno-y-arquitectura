using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonAltaAlumno_Click(object sender, EventArgs e)
        {
            new AltaAlumno().Show();
        }

        private void buttonBajaAlumno_Click(object sender, EventArgs e)
        {
            new BajaAlumno().Show();
        }

        private void buttonModificarAlumno_Click(object sender, EventArgs e)
        {
            new ModificacionAlumno().Show();
        }

        private void buttonAltaCurso_Click(object sender, EventArgs e)
        {
            new AltaCurso().Show();
        }

        private void buttonRecaudacion_Click(object sender, EventArgs e)
        {
            new Recaudacion().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CantidadAlumnos().Show();
        }
    }
}
