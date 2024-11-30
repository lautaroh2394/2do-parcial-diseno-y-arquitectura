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
    public partial class ComboBoxAlumno : UserControl
    {
        public event EventHandler ComboBoxAlumnoChange;

        public ComboBoxAlumno()
        {
            InitializeComponent();
            SetComboBoxDataSource();
            comboBox1.SelectedIndex = 0;
        }

        public int GetSelectedAlumnoId()
        {
            if (comboBox1.SelectedIndex == 0) return -1;
            return (int) comboBox1.SelectedValue;
        }

        private void SetComboBoxDataSource()
        {
            DataSet alumnos = new BLL.Alumnos().GetAlumnos();
            DataTable table = alumnos.Tables[0];
            this.comboBox1.DataSource = table;
            DataRow dr = table.NewRow();
            dr["id"] = -1;
            table.Rows.InsertAt(dr, 0);

            this.comboBox1.DisplayMember = "show_text";
            this.comboBox1.ValueMember = "id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAlumnoChange?.Invoke(this, EventArgs.Empty);
        }
    }
}
