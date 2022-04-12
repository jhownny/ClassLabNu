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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNome.Text,txtCpf.Text,txtEmail.Text);
            c.Inserir(c);
            txtId.Text = c.Id.ToString();

        }
    }
}
