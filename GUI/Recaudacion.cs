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
    public partial class Recaudacion : Form
    {
        private BLL.Cursos cursos;
        private DataSet recaudacion;
        public Recaudacion()
        {
            InitializeComponent();
            cursos = new BLL.Cursos();
            SetRecaudacionPorCursoDataSource();
            SetRecaudacionTotal();
        }

        private void SetRecaudacionTotal()
        {
            float recaudacion = cursos.GetRecaudacionTotal();
            textBoxRecaudacionTotal.Text = recaudacion.ToString();
        }

        private void SetRecaudacionPorCursoDataSource()
        {
            this.recaudacion = cursos.GetRecaudacionPorCursoDataSource();
            DataTable table = recaudacion.Tables[0];
            dataGridView1.DataSource = table;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            recaudacion.WriteXml("C:\\Users\\Lau\\source\\repos\\2do-parcial-diseño-y-arquitectura-lautaro-haase\\recaudacion.xml");
            MessageBox.Show("Info guardada en recaudacion.xml", "Éxito", MessageBoxButtons.OK);
        }
    }
}
