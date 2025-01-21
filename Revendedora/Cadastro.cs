using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revendedora
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conectaBanco conexao = new conectaBanco();

            user novoUser = new user();

            novoUser.Nome = txtnomeemp.Text;
            novoUser.Email = txtemailemp.Text;
            novoUser.Senha = txtsenhaemp.Text;


            bool retorno = conexao.cadastro(novoUser);


            if (retorno == false)
            {

                MessageBox.Show("Houve um erro ao cadastrar-se!");

            }
            else
            {

                Login formulario = new Login();

                this.Hide();

                formulario.ShowDialog();

                this.Close();

            }

        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Login formulario = new Login();

            this.Hide();

            formulario.ShowDialog();

            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
