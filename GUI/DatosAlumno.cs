using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DatosAlumno : UserControl
    {
        public string ValidationMsg;

        public DatosAlumno()
        {
            InitializeComponent();
        }

        public bool Validate()
        {
            bool isValid = true;
            this.ValidationMsg = "";
            string caracteresValidos = "^[a-záéíóú ]+$";
            if (!Regex.IsMatch(textBoxApellido.Text.ToLower().Trim(), caracteresValidos) || textBoxApellido.Text.Length == 0)
            {
                this.ValidationMsg = this.ValidationMsg + "Apellido inválido. ";
            }

            if (!Regex.IsMatch(textBoxNombre.Text.ToLower().Trim(), caracteresValidos) || textBoxNombre.Text.Length == 0)
            {
                this.ValidationMsg = this.ValidationMsg + "Nombre inválido. ";
            }

            if (dateTimePicker1.Value == null)
            {
                this.ValidationMsg = this.ValidationMsg + "Fecha nacimiento inválida.";
            }

            if (this.ValidationMsg.Count() > 0) {
                isValid = false;
            }

            return isValid;
        }

        public void HideId()
        {
            this.textBoxId.Hide();
            this.label1.Hide();
        }

        public string GetNombre()
        {
            return textBoxNombre.Text;
        }

        public string GetApellido()
        {
            return textBoxApellido.Text;
        }

        public int GetId()
        {
            return Int32.Parse(textBoxId.Text);
        }

        public DateTime GetFechaNacimiento()
        {
            return dateTimePicker1.Value;
        }

        public void SetAlumno(BE.Alumno alumno)
        {
            textBoxId.Text = alumno.id.ToString();
            textBoxApellido.Text = alumno.apellido;
            textBoxNombre.Text = alumno.nombre;
            dateTimePicker1.Value = alumno.fecha_nacimiento;
        }

        public void Disable()
        {
            textBoxId.Enabled = false;
            textBoxApellido.Enabled = false;
            textBoxNombre.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        public void DisableId()
        {
            textBoxId.Enabled = false;
        }

        public void Empty()
        {
            textBoxId.Text = "";
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        public BE.Alumno GetAlumno()
        {
            string nombre = GetNombre();
            string apellido = GetApellido();
            DateTime fecha_nacimiento = GetFechaNacimiento();
            int id = GetId();
            BE.Alumno alumno = new BLL.Alumnos().MapAlumno(id, nombre, apellido, fecha_nacimiento);
            return alumno;
        }
    }
}
