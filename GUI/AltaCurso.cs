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
    public partial class AltaCurso : Form
    {
        public AltaCurso()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { 
                float.Parse(textBox2.Text);
            }
            catch {
                textBox2.Text = "";
            }
        }

        private void buttonAltaCurso_Click(object sender, EventArgs e)
        {
            bool invalidName = textBoxNombre.Text.Length == 0;
            bool invalidCupo = numericCosto.Value < 0;
            bool invalidCosto = textBox2.Text.Length == 0 || float.Parse(textBox2.Text) < 0;

           if (invalidName)
            {
                MessageBox.Show("Error", "Ingrese el nombre", MessageBoxButtons.OK);
                return;
            }
            if (invalidCupo)
            {
                MessageBox.Show("Error", "Ingrese un cupo mayor o igual a cero", MessageBoxButtons.OK);
                return;
            }
            if (invalidCosto)
            {
                MessageBox.Show("Error", "Ingrese un costo mayor o igual a cero", MessageBoxButtons.OK);
                return;
            }

            BLL.Cursos cursos = new BLL.Cursos();
            BE.Curso curso = cursos.MapCurso(
                -1,
                textBoxNombre.Text,
                float.Parse(textBox2.Text),
                Int32.Parse(numericCosto.Value.ToString()),
                dateTimePicker1.Value
                );
            int r = cursos.AltaCurso(curso);
            if (r == 0) { MessageBox.Show("No se pudo crear el curso", "Error al crear", MessageBoxButtons.OK); }
            else
            {
                MessageBox.Show("Éxito", "Curso creado", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
