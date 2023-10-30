using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.View
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtbox_usuario.Text;
            string senha = txtBox_senha.Text;

            if (usuario == "admin" && senha == "123")
            {
                this.Visible = false;
                MenuTela Menu = new MenuTela();
                Menu.Show(this);
            }

            else
            {
                MessageBox.Show("Senha ou usuario incorreto");
            }
        }

        private void txtbox_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
