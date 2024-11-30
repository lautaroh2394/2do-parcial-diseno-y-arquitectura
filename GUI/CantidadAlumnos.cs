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
    public partial class CantidadAlumnos : Form
    {
        private DataSet alumnos;
        public CantidadAlumnos()
        {
            InitializeComponent();
            alumnos = new DAL.Acceso().GetDataSourceForProcedure("total_alumnos_por_curso");
            dataGridView1.DataSource = alumnos.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            alumnos.WriteXml("C:\\Users\\Lau\\source\\repos\\2do-parcial-diseño-y-arquitectura-lautaro-haase\\total_alumnos.xml");
            MessageBox.Show("Info guardada en total_alumnos.xml", "Éxito", MessageBoxButtons.OK);
        }
    }
}
