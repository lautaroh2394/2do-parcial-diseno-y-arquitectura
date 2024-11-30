namespace GUI
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAltaAlumno = new System.Windows.Forms.Button();
            this.buttonModificarAlumno = new System.Windows.Forms.Button();
            this.buttonBajaAlumno = new System.Windows.Forms.Button();
            this.buttonAltaCurso = new System.Windows.Forms.Button();
            this.buttonRecaudacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAltaAlumno
            // 
            this.buttonAltaAlumno.Location = new System.Drawing.Point(14, 16);
            this.buttonAltaAlumno.Name = "buttonAltaAlumno";
            this.buttonAltaAlumno.Size = new System.Drawing.Size(159, 23);
            this.buttonAltaAlumno.TabIndex = 0;
            this.buttonAltaAlumno.Text = "Alta alumno";
            this.buttonAltaAlumno.UseVisualStyleBackColor = true;
            this.buttonAltaAlumno.Click += new System.EventHandler(this.buttonAltaAlumno_Click);
            // 
            // buttonModificarAlumno
            // 
            this.buttonModificarAlumno.Location = new System.Drawing.Point(14, 45);
            this.buttonModificarAlumno.Name = "buttonModificarAlumno";
            this.buttonModificarAlumno.Size = new System.Drawing.Size(159, 23);
            this.buttonModificarAlumno.TabIndex = 1;
            this.buttonModificarAlumno.Text = "Modificar alumno";
            this.buttonModificarAlumno.UseVisualStyleBackColor = true;
            this.buttonModificarAlumno.Click += new System.EventHandler(this.buttonModificarAlumno_Click);
            // 
            // buttonBajaAlumno
            // 
            this.buttonBajaAlumno.Location = new System.Drawing.Point(12, 74);
            this.buttonBajaAlumno.Name = "buttonBajaAlumno";
            this.buttonBajaAlumno.Size = new System.Drawing.Size(159, 23);
            this.buttonBajaAlumno.TabIndex = 2;
            this.buttonBajaAlumno.Text = "Baja alumno";
            this.buttonBajaAlumno.UseVisualStyleBackColor = true;
            this.buttonBajaAlumno.Click += new System.EventHandler(this.buttonBajaAlumno_Click);
            // 
            // buttonAltaCurso
            // 
            this.buttonAltaCurso.Location = new System.Drawing.Point(14, 120);
            this.buttonAltaCurso.Name = "buttonAltaCurso";
            this.buttonAltaCurso.Size = new System.Drawing.Size(157, 23);
            this.buttonAltaCurso.TabIndex = 3;
            this.buttonAltaCurso.Text = "Alta curso";
            this.buttonAltaCurso.UseVisualStyleBackColor = true;
            this.buttonAltaCurso.Click += new System.EventHandler(this.buttonAltaCurso_Click);
            // 
            // buttonRecaudacion
            // 
            this.buttonRecaudacion.Location = new System.Drawing.Point(14, 208);
            this.buttonRecaudacion.Name = "buttonRecaudacion";
            this.buttonRecaudacion.Size = new System.Drawing.Size(159, 23);
            this.buttonRecaudacion.TabIndex = 4;
            this.buttonRecaudacion.Text = "Recaudación";
            this.buttonRecaudacion.UseVisualStyleBackColor = true;
            this.buttonRecaudacion.Click += new System.EventHandler(this.buttonRecaudacion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Alumnos por curso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRecaudacion);
            this.Controls.Add(this.buttonAltaCurso);
            this.Controls.Add(this.buttonBajaAlumno);
            this.Controls.Add(this.buttonModificarAlumno);
            this.Controls.Add(this.buttonAltaAlumno);
            this.Name = "MenuPrincipal";
            this.Text = "Cursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAltaAlumno;
        private System.Windows.Forms.Button buttonModificarAlumno;
        private System.Windows.Forms.Button buttonBajaAlumno;
        private System.Windows.Forms.Button buttonAltaCurso;
        private System.Windows.Forms.Button buttonRecaudacion;
        private System.Windows.Forms.Button button1;
    }
}

