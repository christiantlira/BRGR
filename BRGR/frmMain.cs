using BRGR.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRGR
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCadastrarIngrediente_Click(object sender, EventArgs e)
        {
            frmCadastrarIngredientes f = new frmCadastrarIngredientes();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastrarHamburguer f = new frmCadastrarHamburguer();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCardapio f = new frmCardapio();
            f.ShowDialog();
        }

        private void btnEditarIngredientes_Click(object sender, EventArgs e)
        {
            frmIngredientes f = new frmIngredientes();
            f.ShowDialog();
        }

        private void btnEditarHamburguer_Click(object sender, EventArgs e)
        {
            frmHamburgueres f = new frmHamburgueres();
            f.ShowDialog();
        }
    }
}
