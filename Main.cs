using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCorreos
{
    public partial class Main : Form
    {
        frmProfesion frmProfesion = new frmProfesion();
        public Main()
        {
            InitializeComponent();
        }

        private void btnProfesion_Click(object sender, EventArgs e)
        {
            frmProfesion.TopLevel = false;
            pMain.Controls.Add(frmProfesion);
            frmProfesion.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }
    }
}
