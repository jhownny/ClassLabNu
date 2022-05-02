using System;
using System.Windows.Forms;
using ClassLabNu;


namespace ComercialSys91
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
