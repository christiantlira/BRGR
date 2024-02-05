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
    public partial class frmCadastrarIngredientes : Form
    {
        public frmCadastrarIngredientes()
        {
            InitializeComponent();
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
            dt = connectionsql.getData("INSERT INTO tbl_ingredientes" +
                "(nome, preco_tipo, preco, unidades, porcao, preco_unitario, custo) " +
                $"VALUES ('{nome}','{precoTipo}','{preco.ToString().Replace(',', '.')}','{quantidade.ToString().Replace(',', '.')}','{quantidadeHamburguer.ToString().Replace(',', '.')}','{ingrediente.PrecoUnitario.ToString().Replace(',', '.')}','{ingrediente.Custo.ToString().Replace(',', '.')}');");

            MessageBox.Show("Ingrediente Cadastrado com Sucesso!", "Sucesso na Operação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCadastrarIngredientes_Load(object sender, EventArgs e)
        {

        }

        private void cbbPrecoTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbPrecoTipo.Text == "Preco/Unidade")
            {
                txbPorcao.Text = "1";
                txbPorcao.Enabled = false;
            }
            else
            {
                txbPorcao.Text = string.Empty;
                txbPorcao.Enabled = true;
            }
        }
    }
}
