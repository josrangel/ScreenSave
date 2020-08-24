using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSave
{
    public partial class Form1 : Form
    {
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

            // Guarda a un archivo
            bmpCaptura.Save(cmbBxRuta.Text+"\\sS_"+ obtenerMomento()+".png");

            // La muestra en un picture box
            pictrBxCaptura.Image = bmpCaptura;
            pictrBxCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
