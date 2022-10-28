using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.IO;
using System.Windows.Forms;

namespace ProyectoCorreos
{
    public partial class Main : Form
    {
        frmProfesion frmProfesion = new frmProfesion();
        frmCumpleaños frmCumpleaños = new frmCumpleaños();
        frmCartera frmCartera = new frmCartera();
        frmDividendos frmDividendos = new frmDividendos();
        frmCampañas frmCampañas = new frmCampañas();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void btnProfesion_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            frmProfesion.TopLevel = false;
            pMain.Controls.Add(frmProfesion);
            frmProfesion.Show();
        }

        
        private void btnCumpleaños_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            frmCumpleaños.TopLevel = false;
            pMain.Controls.Add(frmCumpleaños);
            frmCumpleaños.Show();
        }

        private void btnDividendos_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            frmDividendos.TopLevel = false;
            pMain.Controls.Add(frmDividendos);
            frmDividendos.Show();
        }

        private void btnCampañas_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            frmCampañas.TopLevel = false;
            pMain.Controls.Add(frmCampañas);
            frmCampañas.Show();
        }

        private void btnCartera_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            frmCartera.TopLevel = false;
            pMain.Controls.Add(frmCartera);
            frmCartera.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiseñoCorreo PrevisualizarCorreo = new DiseñoCorreo();
            PrevisualizarCorreo.webBrowser1.AllowWebBrowserDrop = false;
            PrevisualizarCorreo.webBrowser1.Url = new Uri("http://www.contoso.com/");
            PrevisualizarCorreo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofdPlantilla.Filter = "Html|*.html";
            ofdPlantilla.Title = "Elige la plantilla";
            //File.Create()
            string appPath = Application.StartupPath;
            textBox1.Text = appPath;
                //ofdPlantilla.ShowDialog();
        }
    }
}
