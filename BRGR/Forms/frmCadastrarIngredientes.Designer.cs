namespace BRGR.Forms
{
    partial class frmCadastrarIngredientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbIngrediente = new System.Windows.Forms.TextBox();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbPrecoTipo = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbUnidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPorcao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrediente:";
            // 
            // txbIngrediente
            // 
            this.txbIngrediente.Location = new System.Drawing.Point(96, 12);
            this.txbIngrediente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbIngrediente.Name = "txbIngrediente";
            this.txbIngrediente.Size = new System.Drawing.Size(211, 23);
            this.txbIngrediente.TabIndex = 1;
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(65, 70);
            this.txbPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(242, 23);
            this.txbPreco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço/Tipo:";
            // 
            // cbbPrecoTipo
            // 
            this.cbbPrecoTipo.FormattingEnabled = true;
            this.cbbPrecoTipo.Items.AddRange(new object[] {
            "Preco/Kg",
            "Preco/Unidade"});
            this.cbbPrecoTipo.Location = new System.Drawing.Point(94, 41);
            this.cbbPrecoTipo.Name = "cbbPrecoTipo";
            this.cbbPrecoTipo.Size = new System.Drawing.Size(213, 23);
            this.cbbPrecoTipo.TabIndex = 5;
            this.cbbPrecoTipo.SelectedValueChanged += new System.EventHandler(this.cbbPrecoTipo_SelectedValueChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(34, 184);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(241, 51);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbUnidade
            // 
            this.txbUnidade.Location = new System.Drawing.Point(85, 97);
            this.txbUnidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbUnidade.Name = "txbUnidade";
            this.txbUnidade.Size = new System.Drawing.Size(222, 23);
            this.txbUnidade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidades:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Porção (Kg):";
            // 
            // txbPorcao
            // 
            this.txbPorcao.Location = new System.Drawing.Point(98, 126);
            this.txbPorcao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbPorcao.Name = "txbPorcao";
            this.txbPorcao.Size = new System.Drawing.Size(209, 23);
            this.txbPorcao.TabIndex = 10;
            // 
            // frmCadastrarIngredientes
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
            this.Name = "frmCadastrarIngredientes";
            this.Text = "frmCadastrarIngredientes";
            this.Load += new System.EventHandler(this.frmCadastrarIngredientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIngrediente;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbPrecoTipo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbUnidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPorcao;
    }
}