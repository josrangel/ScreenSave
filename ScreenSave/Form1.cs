using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSave
{
    public partial class Form1 : Form
    {
        String ultimaImagen = "";
        List<String> historialRutas=new List<string>();
        public Form1()
        {
            InitializeComponent();
            inicioRuta();
            llenaCheckPantallas();
        }

        private void inicioRuta()
        {
            var rutaInicial= Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            cmbBxRuta.Text= rutaInicial;
            cmbBxRuta.DataSource = historialRutas;
        }

        private String obtenerMomento()
        {
            DateTime localDate = DateTime.Now;
            return localDate.ToString("yyyyMMdd_HHmmssFF");
        }

        private void llenaCheckPantallas()
        {
            var pantallas=Screen.AllScreens;
            cmbBoxPantallas.DataSource = pantallas;
            cmbBoxPantallas.DisplayMember="DeviceName";
            //cmbBoxPantallas.SelectedValue = "Bounds";
            
            /*foreach (var screen in pantallas)
            {
                
                cmbBoxPantallas.Items.Add("Device Name: " + screen.DeviceName);
                cmbBoxPantallas.Items.Add("Bounds: " +
                    screen.Bounds.ToString());
                cmbBoxPantallas.Items.Add("Type: " +
                    screen.GetType().ToString());
                cmbBoxPantallas.Items.Add("Working Area: " +
                    screen.WorkingArea.ToString());
                cmbBoxPantallas.Items.Add("Primary Screen: " +
                    screen.Primary.ToString());
            }*/
        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            // Instancias de Bitmap y Graphics
            
            Bitmap bmpCaptura = new Bitmap(Screen.AllScreens[cmbBoxPantallas.SelectedIndex].Bounds.Width, Screen.AllScreens[cmbBoxPantallas.SelectedIndex].Bounds.Height);//Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gfxCaptura = Graphics.FromImage(bmpCaptura);

            // Copia la pantalla
            gfxCaptura.CopyFromScreen(Screen.AllScreens[cmbBoxPantallas.SelectedIndex].Bounds.X, Screen.AllScreens[cmbBoxPantallas.SelectedIndex].Bounds.Y, 0, 0, Screen.AllScreens[cmbBoxPantallas.SelectedIndex].Bounds.Size);

            ultimaImagen = cmbBxRuta.Text + "\\sS_" + obtenerMomento() + ".png";
            // Guarda a un archivo
            bmpCaptura.Save(ultimaImagen);
            
            // La muestra en un picture box
            pictrBxCaptura.Image = bmpCaptura;
            pictrBxCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = cmbBxRuta.Text;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    String carpetaSeleccionada = fbd.SelectedPath;
                    cmbBxRuta.Text = carpetaSeleccionada;
                    
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);
                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void pictrBxCaptura_Click(object sender, EventArgs e)
        {
            if (!ultimaImagen.Equals(""))
            {
                Process photoViewer = new Process();
                photoViewer.StartInfo.FileName = ultimaImagen;
                //photoViewer.StartInfo.Arguments = @"Your image file path";
                photoViewer.Start();
            }
        }
    }
}
