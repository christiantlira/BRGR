namespace BRGR.Forms
{
    partial class frmEditarIngrediente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbPorcao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUnidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbbPrecoTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIngrediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbPorcao
            // 
            this.txbPorcao.Location = new System.Drawing.Point(113, 137);
            this.txbPorcao.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txbPorcao.Name = "txbPorcao";
            this.txbPorcao.Size = new System.Drawing.Size(189, 23);
            this.txbPorcao.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Porção (Kg):";
            // 
            // txbUnidade
            // 
            this.txbUnidade.Location = new System.Drawing.Point(98, 104);
            this.txbUnidade.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txbUnidade.Name = "txbUnidade";
            this.txbUnidade.Size = new System.Drawing.Size(204, 23);
            this.txbUnidade.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Unidades:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(13, 177);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(281, 59);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Atualizar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbbPrecoTipo
            // 
            this.cbbPrecoTipo.FormattingEnabled = true;
            this.cbbPrecoTipo.Items.AddRange(new object[] {
            "Preco/Kg",
            "Preco/Unidade"});
            this.cbbPrecoTipo.Location = new System.Drawing.Point(108, 39);
            this.cbbPrecoTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbPrecoTipo.Name = "cbbPrecoTipo";
            this.cbbPrecoTipo.Size = new System.Drawing.Size(194, 23);
            this.cbbPrecoTipo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preço/Tipo:";
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(74, 73);
            this.txbPreco.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(228, 23);
            this.txbPreco.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Preço:";
            // 
            // txbIngrediente
            // 
            this.txbIngrediente.Location = new System.Drawing.Point(110, 6);
            this.txbIngrediente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txbIngrediente.Name = "txbIngrediente";
            this.txbIngrediente.Size = new System.Drawing.Size(192, 23);
            this.txbIngrediente.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingrediente:";
            // 
            // frmEditarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 260);
            this.Controls.Add(this.txbPorcao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbUnidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbbPrecoTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIngrediente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditarIngrediente";
            this.Text = "frmEditarIngrediente";
            this.Load += new System.EventHandler(this.frmEditarIngrediente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbPorcao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUnidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbbPrecoTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIngrediente;
        private System.Windows.Forms.Label label1;
    }
}