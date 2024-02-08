using BRGR.Classes;
using freelaProject.Class.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRGR.Forms
{
    public partial class frmEditarHamburguer : Form
    {
        private string id;
        public frmEditarHamburguer(string id)
        {
            InitializeComponent();
            this.id = id;
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
            lvwHamburguer.Columns.Add("Ingrediente", 100, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Tipo de Preço", 100, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Preço", 50, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Unidades", 75, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Porção(g)", 75, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Preço Unitário", 100, HorizontalAlignment.Left);
            lvwHamburguer.Columns.Add("Custo", 60, HorizontalAlignment.Left);
        }

        private void frmEditarHamburguer_Load(object sender, EventArgs e)
        {
            ConfiguraListas();

            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();

            dt = connectionsql.getData($"SELECT * FROM tbl_hamburgueres WHERE id = '{id}'");
            string[] fkIngredientes = dt.Rows[0]["fk_ingredientes"].ToString().Split('/');
            List<Ingrediente> ingredientes = App.ListaIngredientes(fkIngredientes);
            List<Ingrediente> todosIngre = App.TodosIngredientes();

            foreach(Ingrediente ing in ingredientes )
            {
                ing.Calculos();
                ListViewItem lvi = new ListViewItem(ing.Id.ToString());
                lvi.SubItems.Add(ing.Nome);
                lvi.SubItems.Add(ing.PrecoTipo);
                lvi.SubItems.Add(ing.Preco.ToString("00.00").Replace('.', ','));
                lvi.SubItems.Add(ing.Unidades.ToString("00.00").Replace('.', ','));
                lvi.SubItems.Add(ing.Porcao.ToString("00.00").Replace('.', ','));
                lvi.SubItems.Add(ing.PrecoUnitario.ToString("00.00").Replace('.', ','));
                lvi.SubItems.Add(ing.Custo.ToString("00.00").Replace('.', ','));

                lvwHamburguer.Items.Add(lvi);
            }

            for (int i = 0; i < ingredientes.Count; i++)
            {
                for (int j = 0; j < todosIngre.Count; j++)
                {
                    if (ingredientes[i].Id == todosIngre[j].Id)
                    {
                        Ingrediente item = todosIngre[j];
                        todosIngre.Remove(item);
                        break;
                    }
                }
            }

            foreach (Ingrediente ingrediente in todosIngre)
            {
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
            CalcularCusto();
        }

        private void btnAtualizarHamburguer_Click(object sender, EventArgs e)
        {
            Hamburguer hamburguer = new Hamburguer();
            hamburguer.Nome = txbNomeHamburguer.Text;
            string fkIngredientes = "";

            foreach (ListViewItem lvi in lvwHamburguer.Items)
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.Id = int.Parse(lvi.SubItems[0].Text);
                fkIngredientes += ingrediente.Id + "/";
                ingrediente.Nome = lvi.SubItems[1].Text;
                ingrediente.PrecoTipo = lvi.SubItems[2].Text;
                ingrediente.Preco = double.Parse(lvi.SubItems[3].Text);
                ingrediente.Unidades = double.Parse(lvi.SubItems[4].Text);
                ingrediente.Porcao = double.Parse(lvi.SubItems[5].Text);
                ingrediente.Calculos();

                hamburguer.Ingredientes.Add(ingrediente);
            }
            hamburguer.CalculaCusto();

            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();

            dt = connectionsql.getData("UPDATE tbl_hamburgueres " +
                $"SET nome = '{hamburguer.Nome}', fk_ingredientes = '{fkIngredientes}' " +
                $"WHERE id = '{id}';");
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

        private void CalcularCusto()
        {
            double sum = 0;
            foreach (ListViewItem lvi in lvwHamburguer.Items)
            {
                sum += double.Parse(lvi.SubItems[7].Text);
            }
            lblCusto.Text = sum.ToString("00.00").Replace('.', ',');
        }
    }
}
