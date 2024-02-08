using BRGR.Classes;
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

namespace BRGR.Forms
{
    public partial class frmHamburgueres : Form
    {
        public frmHamburgueres()
        {
            InitializeComponent();
        }

        private void ConfiguraLista()
        {
            // CONFIGURAR LISTA
            lvwHamburguer.View = View.Details;
            // permite ao usuário editar o texto
            lvwHamburguer.LabelEdit = false;
            // permite ao usuário rearranjar as colunas
            lvwHamburguer.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            lvwHamburguer.FullRowSelect = true;
            // Exibe as linhas no ListView
            lvwHamburguer.GridLines = true;

            lvwHamburguer.Items.Clear();
            lvwHamburguer.Columns.Clear();
            lvwHamburguer.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Hambúrguer", 100, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Ingredientes", 200, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Custo", 75, HorizontalAlignment.Left);
        }

        private void frmHamburgueres_Load(object sender, EventArgs e)
        {
            ConfiguraLista();
            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();
            dt = connectionsql.getData("SELECT * FROM tbl_hamburgueres;");

            foreach (DataRow dr in dt.Rows) 
            { 
                int pk = int.Parse(dr["id"].ToString());
                string nome = dr["nome"].ToString();
                string[] fkIngredientes = dr["fk_ingredientes"].ToString().Split('/');
                List<Ingrediente> ingredientes = App.ListaIngredientes(fkIngredientes);

                Hamburguer hamburguer = new Hamburguer();
                hamburguer.Id = pk;
                hamburguer.Nome = nome;
                hamburguer.Ingredientes = ingredientes;
                hamburguer.CalculaCusto();

                ListViewItem lvi = new ListViewItem(hamburguer.Id.ToString());
                lvi.SubItems.Add(hamburguer.Nome);
                lvi.SubItems.Add(hamburguer.ListaIngredientes());
                lvi.SubItems.Add(hamburguer.Custo.ToString("00.00").Replace('.', ','));

                lvwHamburguer.Items.Add(lvi);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idx = lvwHamburguer.SelectedIndices[0];
            string id = lvwHamburguer.Items[idx].SubItems[0].Text;

            frmEditarHamburguer f = new frmEditarHamburguer(id);
            f.ShowDialog();
        }
    }
}
