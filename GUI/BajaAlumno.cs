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
    public partial class BajaAlumno : Form
    {
        private BLL.Alumnos alumnos;
        public BajaAlumno()
        {
            InitializeComponent();
            alumnos = new BLL.Alumnos();
            datosAlumno1.Disable();
            comboBoxAlumno1.ComboBoxAlumnoChange += comboBoxAlumno1_ComboBoxAlumnoChange;
        }

        private void comboBoxAlumno1_ComboBoxAlumnoChange(object sender, EventArgs e)
        {
            int alumnoId = comboBoxAlumno1.GetSelectedAlumnoId();
            if (alumnoId >= 0)
            {
                BE.Alumno alumno = alumnos.GetAlumno(alumnoId);
                datosAlumno1.SetAlumno(alumno);
            }
            else
            {
                datosAlumno1.Empty();
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            if (!datosAlumno1.Validate())
            {
                MessageBox.Show("Error: " + datosAlumno1.ValidationMsg, "Ingrese valores correctos", MessageBoxButtons.OK);
                return;
            }

            int r = alumnos.BajaAlumno(datosAlumno1.GetAlumno());
            if (r == 0) { MessageBox.Show("No se pudo dar de baja", "Error al dar baja", MessageBoxButtons.OK); }
            else
            {
                MessageBox.Show("Éxito", "Alumno eliminado y dado de baja en todos los cursos", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
