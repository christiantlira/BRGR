namespace BRGR.Forms
{
    partial class frmCardapio
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
            this.lvwCardapio = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLucro = new System.Windows.Forms.TextBox();
            this.txbTaxa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwCardapio
            // 
            this.lvwCardapio.HideSelection = false;
            this.lvwCardapio.Location = new System.Drawing.Point(14, 127);
            this.lvwCardapio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwCardapio.Name = "lvwCardapio";
            this.lvwCardapio.Size = new System.Drawing.Size(574, 378);
            this.lvwCardapio.TabIndex = 0;
            this.lvwCardapio.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lucro(%):";
            // 
            // txbLucro
            // 
            this.txbLucro.Location = new System.Drawing.Point(83, 15);
            this.txbLucro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbLucro.Name = "txbLucro";
            this.txbLucro.Size = new System.Drawing.Size(149, 23);
            this.txbLucro.TabIndex = 2;
            this.txbLucro.Text = "25";
            // 
            // txbTaxa
            // 
            this.txbTaxa.Location = new System.Drawing.Point(116, 44);
            this.txbTaxa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbTaxa.Name = "txbTaxa";
            this.txbTaxa.Size = new System.Drawing.Size(116, 23);
            this.txbTaxa.TabIndex = 4;
            this.txbTaxa.Text = "27";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taxa iFood (%):";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(17, 73);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(215, 48);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 519);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txbTaxa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLucro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwCardapio);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCardapio";
            this.Text = "frmCardapio";
            this.Load += new System.EventHandler(this.frmCardapio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwCardapio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLucro;
        private System.Windows.Forms.TextBox txbTaxa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizar;
    }
}