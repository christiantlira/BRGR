namespace BRGR.Forms
{
    partial class frmEditarHamburguer
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAtualizarHamburguer = new System.Windows.Forms.Button();
            this.lblCusto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeHamburguer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lvwHamburguer = new System.Windows.Forms.ListView();
            this.lvwIngredientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(552, 208);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(88, 27);
            this.btnRemover.TabIndex = 17;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAtualizarHamburguer
            // 
            this.btnAtualizarHamburguer.Location = new System.Drawing.Point(771, 20);
            this.btnAtualizarHamburguer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAtualizarHamburguer.Name = "btnAtualizarHamburguer";
            this.btnAtualizarHamburguer.Size = new System.Drawing.Size(161, 23);
            this.btnAtualizarHamburguer.TabIndex = 16;
            this.btnAtualizarHamburguer.Text = "Atualizar Hamburguer";
            this.btnAtualizarHamburguer.UseVisualStyleBackColor = true;
            this.btnAtualizarHamburguer.Click += new System.EventHandler(this.btnAtualizarHamburguer_Click);
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(612, 20);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(21, 15);
            this.lblCusto.TabIndex = 15;
            this.lblCusto.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Custo: R$";
            // 
            // txbNomeHamburguer
            // 
            this.txbNomeHamburguer.Location = new System.Drawing.Point(152, 12);
            this.txbNomeHamburguer.Name = "txbNomeHamburguer";
            this.txbNomeHamburguer.Size = new System.Drawing.Size(186, 23);
            this.txbNomeHamburguer.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome do Hamburguer:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(552, 175);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 27);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lvwHamburguer
            // 
            this.lvwHamburguer.HideSelection = false;
            this.lvwHamburguer.Location = new System.Drawing.Point(645, 67);
            this.lvwHamburguer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwHamburguer.Name = "lvwHamburguer";
            this.lvwHamburguer.Size = new System.Drawing.Size(459, 503);
            this.lvwHamburguer.TabIndex = 10;
            this.lvwHamburguer.UseCompatibleStateImageBehavior = false;
            // 
            // lvwIngredientes
            // 
            this.lvwIngredientes.HideSelection = false;
            this.lvwIngredientes.Location = new System.Drawing.Point(13, 67);
            this.lvwIngredientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwIngredientes.Name = "lvwIngredientes";
            this.lvwIngredientes.Size = new System.Drawing.Size(533, 503);
            this.lvwIngredientes.TabIndex = 9;
            this.lvwIngredientes.UseCompatibleStateImageBehavior = false;
            // 
            // frmEditarHamburguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 582);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAtualizarHamburguer);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomeHamburguer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lvwHamburguer);
            this.Controls.Add(this.lvwIngredientes);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditarHamburguer";
            this.Text = "frmEditarHamburguer";
            this.Load += new System.EventHandler(this.frmEditarHamburguer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAtualizarHamburguer;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeHamburguer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView lvwHamburguer;
        private System.Windows.Forms.ListView lvwIngredientes;
    }
}