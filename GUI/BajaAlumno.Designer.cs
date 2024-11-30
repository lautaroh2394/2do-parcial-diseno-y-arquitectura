namespace GUI
{
    partial class BajaAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBaja = new System.Windows.Forms.Button();
            this.datosAlumno1 = new GUI.DatosAlumno();
            this.comboBoxAlumno1 = new GUI.ComboBoxAlumno();
            this.SuspendLayout();
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(102, 166);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(130, 23);
            this.buttonBaja.TabIndex = 2;
            this.buttonBaja.Text = "Dar de baja al alumno";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // datosAlumno1
            // 
            this.datosAlumno1.Location = new System.Drawing.Point(7, 45);
            this.datosAlumno1.Name = "datosAlumno1";
            this.datosAlumno1.Size = new System.Drawing.Size(321, 107);
            this.datosAlumno1.TabIndex = 1;
            // 
            // comboBoxAlumno1
            // 
            this.comboBoxAlumno1.Location = new System.Drawing.Point(70, 12);
            this.comboBoxAlumno1.Name = "comboBoxAlumno1";
            this.comboBoxAlumno1.Size = new System.Drawing.Size(255, 28);
            this.comboBoxAlumno1.TabIndex = 0;
            // 
            // BajaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 201);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.datosAlumno1);
            this.Controls.Add(this.comboBoxAlumno1);
            this.Name = "BajaAlumno";
            this.Text = "BajaAlumno";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBoxAlumno comboBoxAlumno1;
        private DatosAlumno datosAlumno1;
        private System.Windows.Forms.Button buttonBaja;
    }
}