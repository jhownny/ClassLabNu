using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys91
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Criar Instancia do Formulario Cliente

            FrmCliente frmCliente = new FrmCliente();
            

            //Tornado frmCliente Filho do contaner FrmPrincipal

            frmCliente.MdiParent = this;
            

            //Exibe o Formulario de Cliente no Formprincipal

            frmCliente.Show(); 
            

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();


            frmProduto.MdiParent = this;


            frmProduto.Show();
        }


        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar instância do Formulário Cliente
            FrmCliente frmCliente = new FrmCliente();
            // tornando frmCliente filho do Container FrmPrincipal (this)
            frmCliente.MdiParent = this;
            // exibe o formulário de cliente no formprincipal
            frmCliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar instância do Formulário Produto
            FrmProduto frmProduto = new FrmProduto();
            // tornando frmProdutofilho do Container FrmPrincipal (this)
            frmProduto.MdiParent = this;
            // exibe o formulário de produto no formprincipal
            frmProduto.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // criar instância do Formulário Produto
            FrmUsuario frmUsuario = new FrmUsuario();
            // tornando frmProdutofilho do Container FrmPrincipal (this)
            frmUsuario.MdiParent = this;
            // exibe o formulário de produto no formprincipal
            frmUsuario.Show();
        }
    }
}
