using ClassLabNu;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        /* private void bntIserirProd_Click(object sender, EventArgs e)
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

                 MessageBox.Show("Falha ao inserir produto. - " + MySqlErrorCode.WrongValue);
             }

         }*/





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

                MessageBox.Show("Falha ao inserir produto. - " + MySqlErrorCode.WrongValue);
            }
        }






        private void bntAlterar_Click(object sender, EventArgs e)
        {


            Produto produto = new Produto();


            if (produto.Alterar(int.Parse(txtIdProd.Text), txtUni.Text, txtVl.Text, txtDesconto.Text, txtCod.Text, txtDescricao.Text))
            {

                MessageBox.Show("Produto Alterado com Sucesso!");


            }
            else
            {

                MessageBox.Show("Falha ao alterar Produto.");

            }

        }

        private void btnListarProd_Click(object sender, EventArgs e)
        {


            dgvProdutos.Rows.Clear();
            List<Produto> ListaDeProdutos = Produto.Listar();
            int cont = ListaDeProdutos.Count;
            foreach (Produto produto in ListaDeProdutos)
            {

                dgvProdutos.Rows.Add();
                //dgvClientes.Rows[dgvClientes.NewRowIndex].Cells[0].Value = cliente.Id.ToString();
                dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[0].Value = produto.Id.ToString();
                dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[1].Value = produto.Unidade.ToString();
                dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[2].Value = produto.Valor.ToString();
                dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[3].Value = produto.Desconto.ToString();
                dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[4].Value = produto.CodBar.ToString();
                dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[5].Value = produto.Descricao.ToString();
                dgvProdutos.Rows[dgvProdutos.CurrentRow.Index].Cells[5].Value = produto.Descontinuado;

            }

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "...")
            {

                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "Buscar";

            }
            else
            {
                Produto produtos.BuscarPorId(int.Parse(txtId.Text));







            }




        }
    }
}

