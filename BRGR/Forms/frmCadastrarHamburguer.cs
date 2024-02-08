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
    public partial class frmCadastrarHamburguer : Form
    {
        public frmCadastrarHamburguer()
        {
            InitializeComponent();
        }

        private void ConfiguraListas()
        {
            // CONFIGURAR LISTA
            lvwIngredientes.View = View.Details;
            // permite ao usuário editar o texto
            lvwIngredientes.LabelEdit = false;
            // permite ao usuário rearranjar as colunas
            lvwIngredientes.AllowColumnReorder = true;
            // Selecione o item e subitem quando um seleção for feita
            lvwIngredientes.FullRowSelect = true;
            // Exibe as linhas no ListView
            lvwIngredientes.GridLines = true;

            lvwIngredientes.Items.Clear();
            lvwIngredientes.Columns.Clear();
            lvwIngredientes.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvwIngredientes.Columns.Add("Ingrediente", 100, HorizontalAlignment.Left);
            lvwIngredientes.Columns.Add("Tipo de Preço", 100, HorizontalAlignment.Left);
            lvwIngredientes.Columns.Add("Preço", 50, HorizontalAlignment.Left);
            lvwIngredientes.Columns.Add("Unidades", 75, HorizontalAlignment.Left);
            lvwIngredientes.Columns.Add("Porção(g)", 75, HorizontalAlignment.Left);
            lvwIngredientes.Columns.Add("Preço Unitário", 100, HorizontalAlignment.Left);
            lvwIngredientes.Columns.Add("Custo", 60, HorizontalAlignment.Left);

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
            lvwHamburguer.Columns.Add("Ingrediente", 50, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Tipo de Preço", 50, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Preço", 50, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Unidades", 50, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Porção(g)", 50, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Preço Unitário", 50, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Custo", 50, HorizontalAlignment.Left);
        }

        private void frmCadastrarHamburguer_Load(object sender, EventArgs e)
        {
            ConfiguraListas();
            try
            {


                DataTable dt = new DataTable();
                Connectionsql connectionsql = new Connectionsql();

                dt = connectionsql.getData("SELECT * FROM tbl_ingredientes");

                foreach (DataRow dr in dt.Rows)
                {
                    Ingrediente ingrediente = new Ingrediente();
                    ingrediente.Id = int.Parse(dr["id"].ToString());
                    ingrediente.Nome = dr["nome"].ToString();
                    ingrediente.PrecoTipo = dr["preco_tipo"].ToString();
                    ingrediente.Preco = double.Parse(dr["preco"].ToString());
                    ingrediente.Unidades = double.Parse(dr["unidades"].ToString());
                    ingrediente.Porcao = double.Parse(dr["porcao"].ToString());
                    if (ingrediente.PrecoTipo == "Preco/Kg")
                    {
                        ingrediente.Porcao *= 1000;
                    }
                    ingrediente.Calculos();

                    ListViewItem lvi = new ListViewItem(ingrediente.Id.ToString());
                    lvi.SubItems.Add(ingrediente.Nome);
                    lvi.SubItems.Add(ingrediente.PrecoTipo);
                    lvi.SubItems.Add(ingrediente.Preco.ToString("00.00").Replace('.', ','));
                    lvi.SubItems.Add(ingrediente.Unidades.ToString("00.00").Replace('.', ','));
                    lvi.SubItems.Add(ingrediente.Porcao.ToString("00.00").Replace('.', ','));
                    lvi.SubItems.Add(ingrediente.PrecoUnitario.ToString("00.00").Replace('.', ','));
                    lvi.SubItems.Add(ingrediente.Custo.ToString("00.00").Replace('.', ','));

                    lvwIngredientes.Items.Add(lvi);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcularCusto()
        {
            double sum = 0;
            foreach(ListViewItem lvi in lvwHamburguer.Items)
            {
                sum += double.Parse(lvi.SubItems[7].Text);
            }
            lblCusto.Text = sum.ToString("00.00").Replace('.', ',');
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int idx = lvwIngredientes.SelectedIndices[0];
            ListViewItem lvi = lvwIngredientes.Items[idx];
            
            lvwIngredientes.Items.Remove(lvi);
            lvwHamburguer.Items.Add(lvi);
            
            CalcularCusto();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idx = lvwHamburguer.SelectedIndices[0];
            ListViewItem lvi = lvwHamburguer.Items[idx];

            lvwHamburguer.Items.Remove(lvi);
            lvwIngredientes.Items.Add(lvi);
            
            CalcularCusto();
        }

        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            Hamburguer hamburguer = new Hamburguer();
            hamburguer.Nome = txbNomeHamburguer.Text;
            string fkIngredientes = "";
            
            foreach(ListViewItem lvi in lvwHamburguer.Items)
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = int.Parse(lvi.SubItems[0].Text);
                fkIngredientes += ingrediente.Id + "/";
                ingrediente.Nome = lvi.SubItems[1].Text;
                ingrediente.PrecoTipo = lvi.SubItems[2].Text;
                ingrediente.Preco = double.Parse(lvi.SubItems[3].Text);
                ingrediente.Unidades = double.Parse(lvi.SubItems[4].Text);
                ingrediente.Porcao = double.Parse(lvi.SubItems[5].Text);
                ingrediente.PrecoUnitario = double.Parse(lvi.SubItems[6].Text);
                ingrediente.Custo = double.Parse(lvi.SubItems[7].Text);

                hamburguer.Ingredientes.Add(ingrediente);
            }
            hamburguer.CalculaCusto();

            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();

            dt = connectionsql.getData("INSERT INTO tbl_hamburgueres " +
                "(nome, fk_ingredientes)" +
                $" VALUES ('{hamburguer.Nome}','{fkIngredientes}');");
        }
    }
}
