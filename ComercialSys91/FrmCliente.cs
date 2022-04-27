using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClassLabNu;

namespace ComercialSys91
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnInserirCli_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);

            c.Inserir();


            if (c.Id > 0)
            {
                txtId.Text = c.Id.ToString();
                MessageBox.Show("cliente gravado com sucesso!");
            }
            else
            {

                MessageBox.Show("Falha ao inserir cliente.");

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string usuario = System.Environment.UserName;
            Text += " - " + usuario;

        }





        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlListar_Click(object sender, EventArgs e)
        {

            dgvClientes.Rows.Clear();
            List<Cliente> ListaDeClientes = Cliente.Listar();
            int cont = ListaDeClientes.Count;
            foreach (Cliente cliente in ListaDeClientes)
            {

                dgvClientes.Rows.Add();
                //dgvClientes.Rows[dgvClientes.NewRowIndex].Cells[0].Value = cliente.Id.ToString();
                dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value = cliente.Id.ToString();
                dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[1].Value = cliente.Nome.ToString();
                dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[2].Value = cliente.Cpf.ToString();
                dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[3].Value = cliente.Email.ToString();
                dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[4].Value = cliente.Ativo;

            }

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(btnBuscar.Text == "...")
            {

                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "Buscar";

            }
            else
            {

                Cliente cliente = Cliente.ConsultarPorId(int.Parse(txtId.Text));
                if (cliente.Id > 0)
                {

                    txtNome.Text = cliente.Nome.ToString();
                    txtCpf.Text = cliente.Cpf.ToString();
                    txtEmail.Text = cliente.Email.ToString();
                    dtpData_Cad.Value = cliente.Data_Cad.Date;
                    chkAtivo.Checked = cliente.Ativo;

                    btnBuscar.Text = "...";
                    txtId.ReadOnly=true;
                    btnAlterar.Enabled = true;
                    txtCpf.ReadOnly=true;

                }
                else
                {

                    MessageBox.Show("Este cadastro não existe.");

                }
            }
            



        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();    


            if (cliente.Aterar(int.Parse(txtId.Text),txtNome.Text, txtEmail.Text))
            {

                MessageBox.Show("Cliente Alterado com Sucesso!");


            }
            else
            {

                MessageBox.Show("Falha ao alterar Cliente.");

            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Cep cep = new Cep();


            if()
            {



            }
            else
            {

            }
        }
    }
}
