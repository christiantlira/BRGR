namespace BRGR.Forms
{
    partial class frmCadastrarHamburguer
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
            this.lvwIngredientes = new System.Windows.Forms.ListView();
            this.lvwHamburguer = new System.Windows.Forms.ListView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomeHamburguer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.btnFinalizarCadastro = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwIngredientes
            // 
            this.lvwIngredientes.HideSelection = false;
            this.lvwIngredientes.Location = new System.Drawing.Point(14, 67);
            this.lvwIngredientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwIngredientes.Name = "lvwIngredientes";
            this.lvwIngredientes.Size = new System.Drawing.Size(533, 503);
            this.lvwIngredientes.TabIndex = 0;
            this.lvwIngredientes.UseCompatibleStateImageBehavior = false;
            // 
            // lvwHamburguer
            // 
            this.lvwHamburguer.HideSelection = false;
            this.lvwHamburguer.Location = new System.Drawing.Point(646, 67);
            this.lvwHamburguer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwHamburguer.Name = "lvwHamburguer";
            this.lvwHamburguer.Size = new System.Drawing.Size(459, 503);
            this.lvwHamburguer.TabIndex = 1;
            this.lvwHamburguer.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(553, 175);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 27);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Hamburguer:";
            // 
            // txbNomeHamburguer
            // 
            this.txbNomeHamburguer.Location = new System.Drawing.Point(153, 12);
            this.txbNomeHamburguer.Name = "txbNomeHamburguer";
            this.txbNomeHamburguer.Size = new System.Drawing.Size(186, 23);
            this.txbNomeHamburguer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custo: R$";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(613, 20);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(21, 15);
            this.lblCusto.TabIndex = 6;
            this.lblCusto.Text = "00";
            // 
            // btnFinalizarCadastro
            // 
            this.btnFinalizarCadastro.Location = new System.Drawing.Point(772, 20);
            this.btnFinalizarCadastro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            this.btnFinalizarCadastro.Size = new System.Drawing.Size(161, 23);
            this.btnFinalizarCadastro.TabIndex = 7;
            this.btnFinalizarCadastro.Text = "Finalizar Cadastro";
            this.btnFinalizarCadastro.UseVisualStyleBackColor = true;
            this.btnFinalizarCadastro.Click += new System.EventHandler(this.btnFinalizarCadastro_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(553, 208);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(88, 27);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmCadastrarHamburguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 582);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnFinalizarCadastro);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomeHamburguer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lvwHamburguer);
            this.Controls.Add(this.lvwIngredientes);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCadastrarHamburguer";
            this.Text = "frmCadastrarHamburguer";
            this.Load += new System.EventHandler(this.frmCadastrarHamburguer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwIngredientes;
        private System.Windows.Forms.ListView lvwHamburguer;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomeHamburguer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Button btnFinalizarCadastro;
        private System.Windows.Forms.Button btnRemover;
    }
}