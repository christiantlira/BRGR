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
    public partial class frmEditarIngrediente : Form
    {
        private string id;
        public frmEditarIngrediente(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmEditarIngrediente_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();

            dt = connectionsql.getData($"SELECT * FROM tbl_ingredientes WHERE id = '{id}';");
            string nome = dt.Rows[0]["nome"].ToString();
            string precoTipo = dt.Rows[0]["preco_tipo"].ToString();
            string preco = dt.Rows[0]["preco"].ToString();
            string unidades = dt.Rows[0]["unidades"].ToString();
            string porcao = dt.Rows[0]["porcao"].ToString();

            txbIngrediente.Text = nome;
            cbbPrecoTipo.Text = precoTipo;
            txbPreco.Text = preco;
            txbUnidade.Text = unidades;
            txbPorcao.Text = porcao;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbIngrediente.Text.Trim();
            string precoTipo = cbbPrecoTipo.Text.Trim();
            double preco = double.Parse(txbPreco.Text);
            double quantidade = double.Parse(txbUnidade.Text);
            double quantidadeHamburguer = double.Parse(txbPorcao.Text);

            Ingrediente ingrediente = new Ingrediente();
            ingrediente.Nome = nome;
            ingrediente.PrecoTipo = precoTipo; //
            ingrediente.Preco = preco;
            ingrediente.Unidades = quantidade;
            ingrediente.Porcao = quantidadeHamburguer;
            ingrediente.Calculos();

            DataTable dt = new DataTable();
            Connectionsql connectionsql = new Connectionsql();
            dt = connectionsql.getData("UPDATE tbl_ingredientes " +
                $"SET nome = '{nome}', " +
                $"preco_tipo = '{precoTipo}', " +
                $"preco = '{preco.ToString().Replace(',', '.')}', " +
                $"unidades = '{quantidade.ToString().Replace(',', '.')}', " +
                $"porcao = '{quantidadeHamburguer.ToString().Replace(',', '.')}', " +
                $"preco_unitario = '{ingrediente.PrecoUnitario.ToString().Replace(',', '.')}', " +
                $"custo = '{ingrediente.Custo.ToString().Replace(',', '.')}'" +
                $"WHERE id = '{id}';");

            MessageBox.Show("Ingrediente Atualizado com Sucesso!", "Sucesso na Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
