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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            var lista = Cliente.Listar();
           
            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
