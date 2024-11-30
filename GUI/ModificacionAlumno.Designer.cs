namespace GUI
{
    partial class ModificacionAlumno
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
            this.datosAlumno1 = new GUI.DatosAlumno();
            this.comboBoxAlumno1 = new GUI.ComboBoxAlumno();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datosAlumno1
            // 
            this.datosAlumno1.Location = new System.Drawing.Point(7, 45);
            this.datosAlumno1.Name = "datosAlumno1";
            this.datosAlumno1.Size = new System.Drawing.Size(321, 107);
            this.datosAlumno1.TabIndex = 0;
            // 
            // comboBoxAlumno1
            // 
            this.comboBoxAlumno1.Location = new System.Drawing.Point(70, 12);
            this.comboBoxAlumno1.Name = "comboBoxAlumno1";
            this.comboBoxAlumno1.Size = new System.Drawing.Size(221, 28);
            this.comboBoxAlumno1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificacionAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAlumno1);
            this.Controls.Add(this.datosAlumno1);
            this.Name = "ModificacionAlumno";
            this.Text = "ModificacionAlumno";
            this.ResumeLayout(false);

        }

        #endregion

        private DatosAlumno datosAlumno1;
        private ComboBoxAlumno comboBoxAlumno1;
        private System.Windows.Forms.Button button1;
    }
}