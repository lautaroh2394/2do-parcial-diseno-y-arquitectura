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
    public partial class AltaAlumno : Form
    {
        public AltaAlumno()
        {
            InitializeComponent();
            datosAlumno.HideId();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (!datosAlumno.Validate())
            {
                MessageBox.Show("Error: " + datosAlumno.ValidationMsg, "Ingrese valores correctos", MessageBoxButtons.OK);
                return;
            }
            BLL.Alumnos alumnos = new BLL.Alumnos();
            BE.Alumno alumno = alumnos.MapAlumno(
                -1,
                datosAlumno.GetNombre(),
                datosAlumno.GetApellido(),
                datosAlumno.GetFechaNacimiento()
            );
            int r = alumnos.AltaAlumno(alumno);

            if (r == 0) { MessageBox.Show("No se pudo crear", "Error al crear", MessageBoxButtons.OK); }
            else
            {
                MessageBox.Show("Éxito", "Alumno creado", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
