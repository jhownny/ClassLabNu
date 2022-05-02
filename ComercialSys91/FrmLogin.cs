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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (Program.usuario.Id > 0)
            {

                this.Close();
            }
            else
            {
                lblMensagem.Text = "Email ou Senha incorreto!";
            }
        }
    }
}
