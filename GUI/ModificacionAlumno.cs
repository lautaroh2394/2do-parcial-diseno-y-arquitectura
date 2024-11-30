using BLL;
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
    public partial class ModificacionAlumno : Form
    {
        private Alumnos alumnos;
        public ModificacionAlumno()
        {
            InitializeComponent();
            alumnos = new BLL.Alumnos();
            datosAlumno1.DisableId();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!datosAlumno1.Validate())
            {
                MessageBox.Show("Error: " + datosAlumno1.ValidationMsg, "Ingrese valores correctos", MessageBoxButtons.OK);
                return;
            }

            BE.Alumno alumno = datosAlumno1.GetAlumno();
            int r = alumnos.ModificarAlumno(alumno);
            if (r == 0) { MessageBox.Show("No se pudo modificar", "Error al modificar", MessageBoxButtons.OK); }
            else
            {
                MessageBox.Show("Éxito", "Alumno modificado", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
