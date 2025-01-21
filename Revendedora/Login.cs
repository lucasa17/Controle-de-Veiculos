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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conectaBanco conecta = new conectaBanco();

            if (conecta.verifica(txtemail.Text, txtsenha.Text) == true)
            {

                Form1 formulario = new Form1();

                this.Hide();

                formulario.ShowDialog();

                this.Close();

            }
            else
            {

                MessageBox.Show("Login incorreto!");

            }

        }

        private void linkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Cadastro formulario = new Cadastro();

            this.Hide();

            formulario.ShowDialog();

            this.Close();

        }
    }
}
