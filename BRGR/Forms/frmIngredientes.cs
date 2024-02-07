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
    public partial class frmIngredientes : Form
    {
        public frmIngredientes()
        {
            InitializeComponent();
        }

        private void ConfiguraLista()
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
        }

        private void frmIngredientes_Load(object sender, EventArgs e)
        {
            ConfiguraLista();
            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();

            dt = connectionsql.getData("SELECT * FROM tbl_ingredientes;");
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idx = lvwIngredientes.SelectedIndices[0];
            string id = lvwIngredientes.Items[idx].SubItems[0].Text;

            frmEditarIngrediente f = new frmEditarIngrediente(id);
            f.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmIngredientes_Load(sender, e);
        }
    }
}
