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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbBxRuta = new System.Windows.Forms.ComboBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.pictrBxCaptura = new System.Windows.Forms.PictureBox();
            this.cmbBoxPantallas = new System.Windows.Forms.ComboBox();
            this.labelRuta = new System.Windows.Forms.Label();
            this.labelPantalla = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictrBxCaptura)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBxRuta
            // 
            resources.ApplyResources(this.cmbBxRuta, "cmbBxRuta");
            this.cmbBxRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBxRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cmbBxRuta.BackColor = System.Drawing.Color.White;
            this.cmbBxRuta.FormattingEnabled = true;
            this.cmbBxRuta.Name = "cmbBxRuta";
            // 
            // btnCaptura
            // 
            resources.ApplyResources(this.btnCaptura, "btnCaptura");
            this.btnCaptura.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCaptura.ForeColor = System.Drawing.Color.White;
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // pictrBxCaptura
            // 
            resources.ApplyResources(this.pictrBxCaptura, "pictrBxCaptura");
            this.pictrBxCaptura.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictrBxCaptura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictrBxCaptura.Name = "pictrBxCaptura";
            this.pictrBxCaptura.TabStop = false;
            this.pictrBxCaptura.Click += new System.EventHandler(this.pictrBxCaptura_Click);
            // 
            // cmbBoxPantallas
            // 
            resources.ApplyResources(this.cmbBoxPantallas, "cmbBoxPantallas");
            this.cmbBoxPantallas.FormattingEnabled = true;
            this.cmbBoxPantallas.Name = "cmbBoxPantallas";
            // 
            // labelRuta
            // 
            resources.ApplyResources(this.labelRuta, "labelRuta");
            this.labelRuta.ForeColor = System.Drawing.Color.Black;
            this.labelRuta.Name = "labelRuta";
            // 
            // labelPantalla
            // 
            resources.ApplyResources(this.labelPantalla, "labelPantalla");
            this.labelPantalla.BackColor = System.Drawing.Color.Transparent;
            this.labelPantalla.ForeColor = System.Drawing.Color.Black;
            this.labelPantalla.Name = "labelPantalla";
            // 
            // btnExaminar
            // 
            this.btnExaminar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnExaminar, "btnExaminar");
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.labelPantalla);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.cmbBoxPantallas);
            this.Controls.Add(this.pictrBxCaptura);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.cmbBxRuta);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnExaminar;
    }
}

