using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLabNu;

namespace ComercialSys91
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void bntIserirProd_Click(object sender, EventArgs e)
        {
            Produto c = new Produto(txtUni.Text, txtVl.Text, txtDesconto.Text, txtCod.Text, txtDescricao.Text);

            c.Inserir();


            if (c.Id > 0)
            {
                txtIdProd.Text = c.Id.ToString();
                MessageBox.Show("Produto gravado com sucesso!");
            }
            else
            {

                MessageBox.Show("Falha ao inserir produto.");
            }

        }

        private void btnListarProd_Click(object sender, EventArgs e)
        {
            lstProduto.Items.Clear();
            List<Produto> ListaDeProdutos = Produto.Listar();
            foreach (Produto produto in ListaDeProdutos)
            {

                lstProduto.Items.Add(produto.Id + " - " + produto.Descricao + " - " + produto.CodBar);

            }
        }
    }
}

