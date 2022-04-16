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

            /*var cmd = Banco.Abrir();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                Usuario usuario = new Usuario("Paulo", "gsdf@f.com", new Nivel("caixa", "cx"), "5635345");
                MessageBox.Show("Opa migão " + usuario.Nome + "!");

            }

            Cliente cliente = new Cliente();
            


           
            //Text = "Sistema Comerciaç TI91 - ( " + usuario.Nome + " - " + usuario.Nivel + " )";  
            */


        }



        private void btnListar_Click(object sender, EventArgs e)
        {
            lstClientes.Items.Clear();
            List<Cliente> ListaDeClientes = Cliente.Listar();
            foreach (Cliente cliente in ListaDeClientes)
            {

                lstClientes.Items.Add(cliente.Id + " - " + cliente.Nome);

            }

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
    }
}
