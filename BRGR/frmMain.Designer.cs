namespace BRGR
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarIngrediente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCardapio = new System.Windows.Forms.Button();
            this.btnEditarIngredientes = new System.Windows.Forms.Button();
            this.btnEditarHamburguer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarIngrediente
            // 
            this.btnCadastrarIngrediente.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarIngrediente.Name = "btnCadastrarIngrediente";
            this.btnCadastrarIngrediente.Size = new System.Drawing.Size(183, 118);
            this.btnCadastrarIngrediente.TabIndex = 0;
            this.btnCadastrarIngrediente.Text = "Cadastrar Ingrediente";
            this.btnCadastrarIngrediente.UseVisualStyleBackColor = true;
            this.btnCadastrarIngrediente.Click += new System.EventHandler(this.btnCadastrarIngrediente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 118);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastrar Hambúrguer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCardapio
            // 
            this.btnCardapio.Location = new System.Drawing.Point(390, 12);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.Size = new System.Drawing.Size(183, 118);
            this.btnCardapio.TabIndex = 2;
            this.btnCardapio.Text = "Cardápio";
            this.btnCardapio.UseVisualStyleBackColor = true;
            this.btnCardapio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarIngredientes
            // 
            this.btnEditarIngredientes.Location = new System.Drawing.Point(12, 136);
            this.btnEditarIngredientes.Name = "btnEditarIngredientes";
            this.btnEditarIngredientes.Size = new System.Drawing.Size(183, 118);
            this.btnEditarIngredientes.TabIndex = 3;
            this.btnEditarIngredientes.Text = "Editar Ingrediente";
            this.btnEditarIngredientes.UseVisualStyleBackColor = true;
            this.btnEditarIngredientes.Click += new System.EventHandler(this.btnEditarIngredientes_Click);
            // 
            // btnEditarHamburguer
            // 
            this.btnEditarHamburguer.Location = new System.Drawing.Point(201, 136);
            this.btnEditarHamburguer.Name = "btnEditarHamburguer";
            this.btnEditarHamburguer.Size = new System.Drawing.Size(183, 118);
            this.btnEditarHamburguer.TabIndex = 4;
            this.btnEditarHamburguer.Text = "Editar Hambúrguer";
            this.btnEditarHamburguer.UseVisualStyleBackColor = true;
            this.btnEditarHamburguer.Click += new System.EventHandler(this.btnEditarHamburguer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 262);
            this.Controls.Add(this.btnEditarHamburguer);
            this.Controls.Add(this.btnEditarIngredientes);
            this.Controls.Add(this.btnCardapio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastrarIngrediente);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarIngrediente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCardapio;
        private System.Windows.Forms.Button btnEditarIngredientes;
        private System.Windows.Forms.Button btnEditarHamburguer;
    }
}

