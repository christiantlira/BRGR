using freelaProject.Class.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace BRGR.Forms
{
    public partial class frmCardapio : Form
    {
        public frmCardapio()
        {
            InitializeComponent();
        }

        private void ConfiguraListas()
        {
            // CONFIGURAR LISTA
            lvwCardapio.View = View.Details;
            // permite ao usuário editar o texto
            lvwCardapio.LabelEdit = false;
            // permite ao usuário rearranjar as colunas
            lvwCardapio.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            lvwCardapio.FullRowSelect = true;
            // Exibe as linhas no ListView
            lvwCardapio.GridLines = true;

            lvwCardapio.Items.Clear();
            lvwCardapio.Columns.Clear();
            lvwCardapio.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvwCardapio.Columns.Add("Hambúrguer", 200, HorizontalAlignment.Left);
            lvwCardapio.Columns.Add("Custo", 75, HorizontalAlignment.Left);
            lvwCardapio.Columns.Add("Preço de Venda", 125, HorizontalAlignment.Left);
            lvwCardapio.Columns.Add("Preço iFood", 100, HorizontalAlignment.Left);
            lvwCardapio.Columns.Add("Lucro", 75, HorizontalAlignment.Left); 
        }

        private void frmCardapio_Load(object sender, EventArgs e)
        {
            ConfiguraListas();

            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();

            dt = connectionsql.getData("SELECT * FROM tbl_hamburgueres;");

            foreach (DataRow dr in dt.Rows )
            {
                int id = int.Parse(dr["id"].ToString());
                string nome = dr["nome"].ToString();
                double custo = double.Parse(dr["custo"].ToString());

                ListViewItem lvi = new ListViewItem(id.ToString());
                lvi.SubItems.Add(nome);
                lvi.SubItems.Add(custo.ToString("00.00").Replace('.', ','));
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvwCardapio.Items.Add(lvi);
            }

            btnAtualizar_Click(sender, e);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi in lvwCardapio.Items)
            {
                double precoVenda = double.Parse(lvi.SubItems[2].Text) * (1 + double.Parse(txbLucro.Text)/100);
                double precoIFood = precoVenda * 100 / (100 - double.Parse(txbTaxa.Text));
                double lucro = precoVenda - double.Parse(lvi.SubItems[2].Text);
                
                lvi.SubItems[3].Text = precoVenda.ToString("00.00").Replace('.', ',');
                lvi.SubItems[4].Text = precoIFood.ToString("00.00").Replace('.', ',');
                lvi.SubItems[5].Text = lucro.ToString("00.00").Replace('.', ',');
            }
        }
    }
}
