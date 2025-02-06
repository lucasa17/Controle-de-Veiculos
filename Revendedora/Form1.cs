using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Numerics;

namespace Revendedora
{
    public partial class Form1 : Form
    {

        int idAlterar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Placa_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[1];

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[4];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[4];

        }

        void limpaCamposV()
        {

            txtplaca.Clear();
            intmarca.Text = "";
            txtmodelo.Clear();
            txtcor.Clear();
            intano.Clear();
            decvalor.Clear();

            txtplaca.Focus();

        }

        void limpaCamposVendas()
        {

            txtnomecomp.Clear();
            decvalvenda.Clear();

        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {

            conectaBanco conexao = new conectaBanco();

            Veiculo novoVeiculo = new Veiculo();

            novoVeiculo.Placa = txtplaca.Text;
            novoVeiculo.Marca = Convert.ToInt32(intmarca.SelectedValue.ToString());
            novoVeiculo.Modelo = txtmodelo.Text;
            novoVeiculo.Cor = txtcor.Text;
            novoVeiculo.Ano = Convert.ToInt32(intano.Text);
            novoVeiculo.Valor = Convert.ToDecimal(decvalor.Text);

            bool retorno = conexao.insereVeiculo(novoVeiculo);


            if (retorno == false)
            {

                MessageBox.Show(conexao.mensagem);

            }

            limpaCamposV();
            listaConectaVeiculo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listaConectaMarca();
            listaConectaVeiculo();
            listaConectaVenda();

        }

        public void listaConectaMarca()
        {

            conectaBanco conexao = new conectaBanco();

            DataTable tabelaDados = new DataTable();

            tabelaDados = conexao.listaMarcas();


            //Combobox cadastro
            intmarca.DataSource = tabelaDados;
            intmarca.DisplayMember = "Marcas";
            intmarca.ValueMember = "idMarca";

            //Combobox alterar
            intalteramarca.DataSource = tabelaDados;
            intalteramarca.DisplayMember = "Marcas";
            intalteramarca.ValueMember = "idMarca";

            //Grid Marcas
            gridmarcas.DataSource = tabelaDados;
            gridmarcas.Columns["idMarca"].Visible = false;


        }

        public void listaConectaVeiculo()
        {

            conectaBanco conexao = new conectaBanco();

            DataTable tabelaDados = new DataTable();

            tabelaDados = conexao.listaVeiculos();

            gridveiculos.DataSource = tabelaDados;
            gridveiculos.Columns["idVeiculo"].Visible = false;

        }

        public void listaConectaVenda()
        {

            conectaBanco conexao = new conectaBanco();

            DataTable tabelaDados = new DataTable();

            tabelaDados = conexao.listaVendas();

            gridvendas.DataSource = tabelaDados;
            gridvendas.Columns["idVendas"].Visible = false;
            gridvendas.Columns["idVeiculo_fk"].Visible = false;



        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        void limpaCamposM()
        {

            txtmarca.Clear();

            txtmarca.Focus();

        }


        private void botaoAdicionaMarca_Click_1(object sender, EventArgs e)
        {

            conectaBanco conexao = new conectaBanco();

            Marca novaMarca = new Marca();

            novaMarca.Nome = txtmarca.Text;

            bool retorno = conexao.insereMarca(novaMarca);

            limpaCamposM();

            listaConectaMarca();
        }

        private void txtbuscacor_TextChanged(object sender, EventArgs e)
        {

            (gridveiculos.DataSource as DataTable).DefaultView.RowFilter =
             string.Format("cor like '{0}%'", txtbuscacor.Text);

        }

        private void txtbusca_TextChanged(object sender, EventArgs e)
        {

            (gridveiculos.DataSource as DataTable).DefaultView.RowFilter =
             string.Format("placa like '{0}%'", txtbusca.Text);

        }

        private void txtbuscamarca_TextChanged(object sender, EventArgs e)
        {

            (gridveiculos.DataSource as DataTable).DefaultView.RowFilter =
             string.Format("marca like '{0}%'", txtbuscamarca.Text);

        }

        private void txtbuscamodelo_TextChanged(object sender, EventArgs e)
        {

            (gridveiculos.DataSource as DataTable).DefaultView.RowFilter =
             string.Format("modelo like '{0}%'", txtbuscamodelo.Text);

        }

        private void gridveiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botaodeletar_Click(object sender, EventArgs e)
        {

            int linha = gridveiculos.CurrentRow.Index;
            int id = Convert.ToInt32(gridveiculos.Rows[linha].Cells["idVeiculo"].Value.ToString());

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja deletar esse veículo?",
                "Remover Veículo", MessageBoxButtons.OKCancel);


            if (resposta == DialogResult.OK)
            {

                conectaBanco conexao = new conectaBanco();

                bool retorno = conexao.deletaVeiculo(id);

                if (retorno == true)
                {

                    MessageBox.Show("Veículo deletado com sucesso!");
                    listaConectaVeiculo();

                }
                else
                {
                    MessageBox.Show(conexao.mensagem);
                }

            }
        }

        private void botaoalterar_Click(object sender, EventArgs e)
        {

            int linha = gridveiculos.CurrentRow.Index;

            idAlterar = Convert.ToInt32(gridveiculos.Rows[linha].Cells["idVeiculo"].Value.ToString());

            txtalteraplaca.Text = gridveiculos.Rows[linha].Cells["placa"].Value.ToString();

            txtalteramodelo.Text = gridveiculos.Rows[linha].Cells["modelo"].Value.ToString();

            txtalteracor.Text = gridveiculos.Rows[linha].Cells["cor"].Value.ToString();

            intalteraano.Text = gridveiculos.Rows[linha].Cells["ano"].Value.ToString();

            decalteravalor.Text = gridveiculos.Rows[linha].Cells["valor"].Value.ToString();

            intalteramarca.Text = gridveiculos.Rows[linha].Cells["marca"].Value.ToString();

            tabControl1.SelectedTab = tabControl1.TabPages[2];

        }

        private void botaoalterarveiculo_Click(object sender, EventArgs e)
        {

            conectaBanco conexao = new conectaBanco();

            Veiculo novoVeiculo = new Veiculo();

            novoVeiculo.Placa = txtalteraplaca.Text;
            novoVeiculo.Marca = Convert.ToInt32(intalteramarca.SelectedValue.ToString());
            novoVeiculo.Modelo = txtalteramodelo.Text;
            novoVeiculo.Cor = txtalteracor.Text;
            novoVeiculo.Ano = Convert.ToInt32(intalteraano.Text);
            novoVeiculo.Valor = Convert.ToDecimal(decalteravalor.Text);

            bool retorno = conexao.alteraVeiculo(novoVeiculo, idAlterar);


            if (retorno == false)
            {

                MessageBox.Show(conexao.mensagem);

            }

            listaConectaVeiculo();

            tabControl1.SelectedTab = tabControl1.TabPages[1];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            tabControl1.SelectedTab = tabControl1.TabPages[3];

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaovender_Click(object sender, EventArgs e)
        {

            int linha = gridveiculos.CurrentRow.Index;

            idAlterar = Convert.ToInt32(gridveiculos.Rows[linha].Cells["idVeiculo"].Value.ToString());

            tabControl1.SelectedTab = tabControl1.TabPages[3];

        }

        private void linkLabel4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            tabControl1.SelectedTab = tabControl1.TabPages[5];


        }

        private void botaovenda_Click(object sender, EventArgs e)
        {

            conectaBanco conexao = new conectaBanco();

            Venda novaVenda = new Venda();

            novaVenda.Nome = txtnomecomp.Text;
            novaVenda.Valor = Convert.ToDecimal(decvalvenda.Text);
            //novaVenda.Cpf = txtcpfcomp.Text;


            bool retorno = conexao.insereVenda(novaVenda, idAlterar);


            if (retorno == false)
            {

                MessageBox.Show(conexao.mensagem);

            }

            listaConectaVenda();
            listaConectaVeiculo();
            limpaCamposVendas();


            tabControl1.SelectedTab = tabControl1.TabPages[5];

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void txtcomprador_TextChanged(object sender, EventArgs e)
        {

            (gridvendas.DataSource as DataTable).DefaultView.RowFilter =
             string.Format("Comprador like '{0}%'", txtcomprador.Text);


        }

        private void botaoDeletaMarca_Click(object sender, EventArgs e)
        {

            int linha = gridmarcas.CurrentRow.Index;
            int id = Convert.ToInt32(gridmarcas.Rows[linha].Cells["idMarca"].Value.ToString());

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja deletar essa marca?",
                "Remover Marca", MessageBoxButtons.OKCancel);


            if (resposta == DialogResult.OK)
            {

                conectaBanco conexao = new conectaBanco();

                bool retorno = conexao.deletaMarca(id);

                if (retorno == true)
                {

                    MessageBox.Show("Marca deletada com sucesso!");
                    listaConectaMarca();
                    listaConectaVeiculo();


                }
                else
                {
                    MessageBox.Show(conexao.mensagem);
                }

            }

        }

        private void botaoDeletaVenda_Click(object sender, EventArgs e)
        {

            int linha = gridvendas.CurrentRow.Index;
            int id = Convert.ToInt32(gridvendas.Rows[linha].Cells["idVeiculo_fk"].Value.ToString());

            DialogResult resposta = MessageBox.Show("Tem certeza que deseja deletar essa venda?",
                "Remover Venda", MessageBoxButtons.OKCancel);


            if (resposta == DialogResult.OK)
            {

                conectaBanco conexao = new conectaBanco();

                bool retorno = conexao.deletaVeiculo(id);

                if (retorno == true)
                {

                    MessageBox.Show("Venda deletada com sucesso!");
                    listaConectaVenda();
                    listaConectaVeiculo();


                }
                else
                {
                    MessageBox.Show(conexao.mensagem);
                }

            }
        }

        private void txtplaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void intmarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

