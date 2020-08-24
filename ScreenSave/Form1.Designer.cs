namespace ScreenSave
{
    partial class Form1
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
            this.cmbBxRuta = new System.Windows.Forms.ComboBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.pictrBxCaptura = new System.Windows.Forms.PictureBox();
            this.cmbBoxPantallas = new System.Windows.Forms.ComboBox();
            this.labelRuta = new System.Windows.Forms.Label();
            this.labelPantalla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictrBxCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBxRuta
            // 
            this.cmbBxRuta.AccessibleDescription = "Aqui se pone la ruta donde se guardaran las capturas de pantalla";
            this.cmbBxRuta.AccessibleName = "Campo de ruta";
            this.cmbBxRuta.BackColor = System.Drawing.Color.White;
            this.cmbBxRuta.FormattingEnabled = true;
            this.cmbBxRuta.Location = new System.Drawing.Point(48, 14);
            this.cmbBxRuta.Name = "cmbBxRuta";
            this.cmbBxRuta.Size = new System.Drawing.Size(343, 21);
            this.cmbBxRuta.TabIndex = 0;
            // 
            // btnCaptura
            // 
            this.btnCaptura.AccessibleDescription = "Este boton sirve para tomar la captura de pantalla";
            this.btnCaptura.AccessibleName = "Boton captura";
            this.btnCaptura.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCaptura.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptura.ForeColor = System.Drawing.Color.White;
            this.btnCaptura.Location = new System.Drawing.Point(397, 12);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(75, 23);
            this.btnCaptura.TabIndex = 1;
            this.btnCaptura.Text = "Captura";
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // pictrBxCaptura
            // 
            this.pictrBxCaptura.AccessibleDescription = "Aqui se muestra la ultima captura de pantalla cuando se guarda";
            this.pictrBxCaptura.AccessibleName = "Campo imagen";
            this.pictrBxCaptura.Location = new System.Drawing.Point(184, 46);
            this.pictrBxCaptura.Name = "pictrBxCaptura";
            this.pictrBxCaptura.Size = new System.Drawing.Size(288, 253);
            this.pictrBxCaptura.TabIndex = 2;
            this.pictrBxCaptura.TabStop = false;
            // 
            // cmbBoxPantallas
            // 
            this.cmbBoxPantallas.AccessibleDescription = "Aqui se enlistan las pantallas con las que cuenta tu equipo, se debe especificar " +
    "una, de la cual tomara la captura de pantalla";
            this.cmbBoxPantallas.AccessibleName = "Campo Pantalla";
            this.cmbBoxPantallas.FormattingEnabled = true;
            this.cmbBoxPantallas.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cmbBoxPantallas.Location = new System.Drawing.Point(60, 46);
            this.cmbBoxPantallas.Name = "cmbBoxPantallas";
            this.cmbBoxPantallas.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPantallas.TabIndex = 3;
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRuta.Location = new System.Drawing.Point(4, 15);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(37, 12);
            this.labelRuta.TabIndex = 4;
            this.labelRuta.Text = "Ruta: ";
            // 
            // labelPantalla
            // 
            this.labelPantalla.AccessibleDescription = "";
            this.labelPantalla.AccessibleName = "";
            this.labelPantalla.AutoSize = true;
            this.labelPantalla.BackColor = System.Drawing.Color.Transparent;
            this.labelPantalla.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPantalla.Location = new System.Drawing.Point(4, 49);
            this.labelPantalla.Name = "labelPantalla";
            this.labelPantalla.Size = new System.Drawing.Size(56, 12);
            this.labelPantalla.TabIndex = 5;
            this.labelPantalla.Text = "Pantalla: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 311);
            this.Controls.Add(this.labelPantalla);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.cmbBoxPantallas);
            this.Controls.Add(this.pictrBxCaptura);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.cmbBxRuta);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "ScreenSave";
            ((System.ComponentModel.ISupportInitialize)(this.pictrBxCaptura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxRuta;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.PictureBox pictrBxCaptura;
        private System.Windows.Forms.ComboBox cmbBoxPantallas;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.Label labelPantalla;
    }
}

