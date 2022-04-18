namespace ComercialSys91
{
    partial class FrmProduto
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lstProduto = new System.Windows.Forms.ListBox();
            this.bntIserirProd = new System.Windows.Forms.Button();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtUni = new System.Windows.Forms.TextBox();
            this.txtVl = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnListarProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Desconto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lstProduto
            // 
            this.lstProduto.FormattingEnabled = true;
            this.lstProduto.Location = new System.Drawing.Point(298, 32);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(402, 238);
            this.lstProduto.TabIndex = 1;
            // 
            // bntIserirProd
            // 
            this.bntIserirProd.Location = new System.Drawing.Point(35, 247);
            this.bntIserirProd.Name = "bntIserirProd";
            this.bntIserirProd.Size = new System.Drawing.Size(75, 23);
            this.bntIserirProd.TabIndex = 2;
            this.bntIserirProd.Text = "&Inserir";
            this.bntIserirProd.UseVisualStyleBackColor = true;
            
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(108, 46);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.ReadOnly = true;
            this.txtIdProd.Size = new System.Drawing.Size(66, 20);
            this.txtIdProd.TabIndex = 3;
            // 
            // txtUni
            // 
            this.txtUni.Location = new System.Drawing.Point(90, 72);
            this.txtUni.Name = "txtUni";
            this.txtUni.Size = new System.Drawing.Size(100, 20);
            this.txtUni.TabIndex = 4;
            // 
            // txtVl
            // 
            this.txtVl.Location = new System.Drawing.Point(90, 98);
            this.txtVl.Name = "txtVl";
            this.txtVl.Size = new System.Drawing.Size(100, 20);
            this.txtVl.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(90, 150);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 7;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(90, 124);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(90, 180);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 9;
            // 
            // btnListarProd
            // 
            this.btnListarProd.Location = new System.Drawing.Point(463, 336);
            this.btnListarProd.Name = "btnListarProd";
            this.btnListarProd.Size = new System.Drawing.Size(100, 23);
            this.btnListarProd.TabIndex = 10;
            this.btnListarProd.Text = "&Listar Produtos";
            this.btnListarProd.UseVisualStyleBackColor = true;
            this.btnListarProd.Click += new System.EventHandler(this.btnListarProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Unidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor";
            // 
            // Desconto
            // 
            this.Desconto.AutoSize = true;
            this.Desconto.Location = new System.Drawing.Point(31, 131);
            this.Desconto.Name = "Desconto";
            this.Desconto.Size = new System.Drawing.Size(53, 13);
            this.Desconto.TabIndex = 13;
            this.Desconto.Text = "Desconto";
            this.Desconto.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cod_Bar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Desconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarProd);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtVl);
            this.Controls.Add(this.txtUni);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.bntIserirProd);
            this.Controls.Add(this.lstProduto);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lstProduto;
        private System.Windows.Forms.Button bntIserirProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.TextBox txtVl;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnListarProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Desconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}