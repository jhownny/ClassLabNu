﻿namespace ComercialSys91
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bntIserirProd = new System.Windows.Forms.Button();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtUni = new System.Windows.Forms.TextBox();
            this.txtVl = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(298, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(402, 238);
            this.listBox1.TabIndex = 1;
            // 
            // bntIserirProd
            // 
            this.bntIserirProd.Location = new System.Drawing.Point(60, 247);
            this.bntIserirProd.Name = "bntIserirProd";
            this.bntIserirProd.Size = new System.Drawing.Size(75, 23);
            this.bntIserirProd.TabIndex = 2;
            this.bntIserirProd.Text = "&Inserir";
            this.bntIserirProd.UseVisualStyleBackColor = true;
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(78, 50);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.ReadOnly = true;
            this.txtIdProd.Size = new System.Drawing.Size(66, 20);
            this.txtIdProd.TabIndex = 3;
            // 
            // txtUni
            // 
            this.txtUni.Location = new System.Drawing.Point(60, 76);
            this.txtUni.Name = "txtUni";
            this.txtUni.Size = new System.Drawing.Size(100, 20);
            this.txtUni.TabIndex = 4;
            // 
            // txtVl
            // 
            this.txtVl.Location = new System.Drawing.Point(60, 102);
            this.txtVl.Name = "txtVl";
            this.txtVl.Size = new System.Drawing.Size(100, 20);
            this.txtVl.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(60, 154);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 7;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(60, 128);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 8;
            // 
            // txtDescrição
            // 
            this.txtDescrição.Location = new System.Drawing.Point(60, 180);
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(100, 20);
            this.txtDescrição.TabIndex = 9;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtVl);
            this.Controls.Add(this.txtUni);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.bntIserirProd);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bntIserirProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtUni;
        private System.Windows.Forms.TextBox txtVl;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtDescrição;
    }
}