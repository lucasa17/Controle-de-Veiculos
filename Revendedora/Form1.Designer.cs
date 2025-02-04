namespace Revendedora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            txtcor = new TextBox();
            botaoCadastro = new Button();
            decvalor = new TextBox();
            label7 = new Label();
            intmarca = new ComboBox();
            intano = new TextBox();
            txtmodelo = new TextBox();
            txtplaca = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Placa = new Label();
            tabPage2 = new TabPage();
            botaovender = new Button();
            txtbuscacor = new TextBox();
            txtbuscamodelo = new TextBox();
            label9 = new Label();
            label19 = new Label();
            label20 = new Label();
            label18 = new Label();
            txtbuscamarca = new TextBox();
            button7 = new Button();
            button6 = new Button();
            txtbusca = new TextBox();
            gridveiculos = new DataGridView();
            tabPage3 = new TabPage();
            button5 = new Button();
            intalteramarca = new ComboBox();
            label17 = new Label();
            txtalteracor = new TextBox();
            label16 = new Label();
            decalteravalor = new TextBox();
            intalteraano = new TextBox();
            txtalteramodelo = new TextBox();
            txtalteraplaca = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            tabPage6 = new TabPage();
            label24 = new Label();
            button1 = new Button();
            decvalvenda = new TextBox();
            label23 = new Label();
            txtnomecomp = new TextBox();
            maskedTextBox4 = new MaskedTextBox();
            label10 = new Label();
            tabPage5 = new TabPage();
            button4 = new Button();
            label21 = new Label();
            gridmarcas = new DataGridView();
            button2 = new Button();
            txtmarca = new TextBox();
            label8 = new Label();
            label6 = new Label();
            tabPage4 = new TabPage();
            button8 = new Button();
            label25 = new Label();
            txtcomprador = new TextBox();
            gridvendas = new DataGridView();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabel4 = new LinkLabel();
            label22 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridveiculos).BeginInit();
            tabPage3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridmarcas).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridvendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(138, 72);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(660, 309);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(txtcor);
            tabPage1.Controls.Add(botaoCadastro);
            tabPage1.Controls.Add(decvalor);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(intmarca);
            tabPage1.Controls.Add(intano);
            tabPage1.Controls.Add(txtmodelo);
            tabPage1.Controls.Add(txtplaca);
            tabPage1.Controls.Add(maskedTextBox3);
            tabPage1.Controls.Add(maskedTextBox2);
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(Placa);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(652, 279);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(599, 81);
            button3.Name = "button3";
            button3.Size = new Size(26, 26);
            button3.TabIndex = 21;
            button3.Text = "+";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtcor
            // 
            txtcor.Location = new Point(365, 154);
            txtcor.Name = "txtcor";
            txtcor.Size = new Size(228, 25);
            txtcor.TabIndex = 20;
            // 
            // botaoCadastro
            // 
            botaoCadastro.BackColor = Color.Transparent;
            botaoCadastro.Cursor = Cursors.Hand;
            botaoCadastro.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botaoCadastro.Location = new Point(264, 231);
            botaoCadastro.Name = "botaoCadastro";
            botaoCadastro.Size = new Size(102, 36);
            botaoCadastro.TabIndex = 19;
            botaoCadastro.Text = "Cadastrar";
            botaoCadastro.UseVisualStyleBackColor = false;
            botaoCadastro.Click += botaoCadastro_Click;
            // 
            // decvalor
            // 
            decvalor.Location = new Point(83, 192);
            decvalor.Name = "decvalor";
            decvalor.Size = new Size(510, 25);
            decvalor.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Javanese Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(220, 18);
            label7.Name = "label7";
            label7.Size = new Size(218, 45);
            label7.TabIndex = 3;
            label7.Text = "Cadastre seu veículo";
            // 
            // intmarca
            // 
            intmarca.FormattingEnabled = true;
            intmarca.Location = new Point(386, 81);
            intmarca.Name = "intmarca";
            intmarca.Size = new Size(207, 25);
            intmarca.TabIndex = 17;
            // 
            // intano
            // 
            intano.Location = new Point(83, 154);
            intano.Name = "intano";
            intano.Size = new Size(236, 25);
            intano.TabIndex = 16;
            // 
            // txtmodelo
            // 
            txtmodelo.Location = new Point(83, 112);
            txtmodelo.Name = "txtmodelo";
            txtmodelo.Size = new Size(510, 25);
            txtmodelo.TabIndex = 14;
            txtmodelo.TextChanged += txtmodelo_TextChanged;
            // 
            // txtplaca
            // 
            txtplaca.Location = new Point(83, 77);
            txtplaca.Name = "txtplaca";
            txtplaca.Size = new Size(236, 25);
            txtplaca.TabIndex = 13;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(45, 154);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(0, 25);
            maskedTextBox3.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(58, 121);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(0, 25);
            maskedTextBox2.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(51, 92);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(0, 25);
            maskedTextBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(324, 81);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Marca: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 191);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "Valor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(324, 153);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 3;
            label3.Text = "Cor:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 153);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Ano:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 111);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Modelo: ";
            // 
            // Placa
            // 
            Placa.AutoSize = true;
            Placa.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Placa.Location = new Point(16, 76);
            Placa.Name = "Placa";
            Placa.Size = new Size(49, 20);
            Placa.TabIndex = 0;
            Placa.Text = "Placa:";
            Placa.Click += Placa_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(botaovender);
            tabPage2.Controls.Add(txtbuscacor);
            tabPage2.Controls.Add(txtbuscamodelo);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(txtbuscamarca);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(txtbusca);
            tabPage2.Controls.Add(gridveiculos);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(652, 279);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar";
            // 
            // botaovender
            // 
            botaovender.Location = new Point(374, 38);
            botaovender.Name = "botaovender";
            botaovender.Size = new Size(77, 44);
            botaovender.TabIndex = 14;
            botaovender.Text = "Vender";
            botaovender.UseVisualStyleBackColor = true;
            botaovender.Click += botaovender_Click;
            // 
            // txtbuscacor
            // 
            txtbuscacor.Location = new Point(261, 21);
            txtbuscacor.Name = "txtbuscacor";
            txtbuscacor.Size = new Size(101, 25);
            txtbuscacor.TabIndex = 10;
            txtbuscacor.TextChanged += txtbuscacor_TextChanged;
            // 
            // txtbuscamodelo
            // 
            txtbuscamodelo.Location = new Point(261, 56);
            txtbuscamodelo.Name = "txtbuscamodelo";
            txtbuscamodelo.Size = new Size(101, 25);
            txtbuscamodelo.TabIndex = 13;
            txtbuscamodelo.TextChanged += txtbuscamodelo_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(189, 58);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 12;
            label9.Text = "Modelo:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(189, 25);
            label19.Name = "label19";
            label19.Size = new Size(38, 20);
            label19.TabIndex = 9;
            label19.Text = "Cor:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(31, 58);
            label20.Name = "label20";
            label20.Size = new Size(56, 20);
            label20.TabIndex = 9;
            label20.Text = "Marca:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(31, 25);
            label18.Name = "label18";
            label18.Size = new Size(49, 20);
            label18.TabIndex = 7;
            label18.Text = "Placa:";
            // 
            // txtbuscamarca
            // 
            txtbuscamarca.Location = new Point(93, 57);
            txtbuscamarca.Name = "txtbuscamarca";
            txtbuscamarca.Size = new Size(89, 25);
            txtbuscamarca.TabIndex = 6;
            txtbuscamarca.TextChanged += txtbuscamarca_TextChanged;
            // 
            // button7
            // 
            button7.Location = new Point(540, 38);
            button7.Name = "button7";
            button7.Size = new Size(77, 44);
            button7.TabIndex = 5;
            button7.Text = "Alterar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += botaoalterar_Click;
            // 
            // button6
            // 
            button6.Location = new Point(457, 38);
            button6.Name = "button6";
            button6.Size = new Size(77, 44);
            button6.TabIndex = 4;
            button6.Text = "Deletar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += botaodeletar_Click;
            // 
            // txtbusca
            // 
            txtbusca.Location = new Point(93, 21);
            txtbusca.Name = "txtbusca";
            txtbusca.Size = new Size(89, 25);
            txtbusca.TabIndex = 2;
            txtbusca.TextChanged += txtbusca_TextChanged;
            // 
            // gridveiculos
            // 
            gridveiculos.BackgroundColor = Color.WhiteSmoke;
            gridveiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridveiculos.Location = new Point(31, 90);
            gridveiculos.Name = "gridveiculos";
            gridveiculos.Size = new Size(586, 175);
            gridveiculos.TabIndex = 0;
            gridveiculos.CellContentClick += gridveiculos_CellContentClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(intalteramarca);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(txtalteracor);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(decalteravalor);
            tabPage3.Controls.Add(intalteraano);
            tabPage3.Controls.Add(txtalteramodelo);
            tabPage3.Controls.Add(txtalteraplaca);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(652, 279);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Alterar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(271, 229);
            button5.Name = "button5";
            button5.Size = new Size(80, 36);
            button5.TabIndex = 24;
            button5.Text = "Alterar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += botaoalterarveiculo_Click;
            // 
            // intalteramarca
            // 
            intalteramarca.FormattingEnabled = true;
            intalteramarca.Location = new Point(397, 68);
            intalteramarca.Name = "intalteramarca";
            intalteramarca.Size = new Size(207, 25);
            intalteramarca.TabIndex = 23;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(332, 69);
            label17.Name = "label17";
            label17.Size = new Size(60, 20);
            label17.TabIndex = 22;
            label17.Text = "Marca: ";
            // 
            // txtalteracor
            // 
            txtalteracor.Location = new Point(376, 148);
            txtalteracor.Name = "txtalteracor";
            txtalteracor.Size = new Size(228, 25);
            txtalteracor.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(332, 149);
            label16.Name = "label16";
            label16.Size = new Size(38, 20);
            label16.TabIndex = 20;
            label16.Text = "Cor:";
            // 
            // decalteravalor
            // 
            decalteravalor.Location = new Point(90, 187);
            decalteravalor.Name = "decalteravalor";
            decalteravalor.Size = new Size(514, 25);
            decalteravalor.TabIndex = 19;
            // 
            // intalteraano
            // 
            intalteraano.Location = new Point(90, 145);
            intalteraano.Name = "intalteraano";
            intalteraano.Size = new Size(236, 25);
            intalteraano.TabIndex = 17;
            // 
            // txtalteramodelo
            // 
            txtalteramodelo.Location = new Point(90, 104);
            txtalteramodelo.Name = "txtalteramodelo";
            txtalteramodelo.Size = new Size(514, 25);
            txtalteramodelo.TabIndex = 15;
            // 
            // txtalteraplaca
            // 
            txtalteraplaca.Location = new Point(90, 65);
            txtalteraplaca.Name = "txtalteraplaca";
            txtalteraplaca.Size = new Size(236, 25);
            txtalteraplaca.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(14, 188);
            label15.Name = "label15";
            label15.Size = new Size(50, 20);
            label15.TabIndex = 7;
            label15.Text = "Valor:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(14, 145);
            label14.Name = "label14";
            label14.Size = new Size(41, 20);
            label14.TabIndex = 6;
            label14.Text = "Ano:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(14, 104);
            label13.Name = "label13";
            label13.Size = new Size(70, 20);
            label13.TabIndex = 5;
            label13.Text = "Modelo: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Javanese Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(220, 20);
            label12.Name = "label12";
            label12.Size = new Size(194, 45);
            label12.TabIndex = 4;
            label12.Text = "Altere seu veículo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 66);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 1;
            label11.Text = "Placa:";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label24);
            tabPage6.Controls.Add(button1);
            tabPage6.Controls.Add(decvalvenda);
            tabPage6.Controls.Add(label23);
            tabPage6.Controls.Add(txtnomecomp);
            tabPage6.Controls.Add(maskedTextBox4);
            tabPage6.Controls.Add(label10);
            tabPage6.Location = new Point(4, 26);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(652, 279);
            tabPage6.TabIndex = 6;
            tabPage6.Text = "Vender";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Javanese Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(219, 18);
            label24.Name = "label24";
            label24.Size = new Size(192, 45);
            label24.TabIndex = 22;
            label24.Text = "Venda seu veículo";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(254, 203);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 21;
            button1.Text = "Vender";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // decvalvenda
            // 
            decvalvenda.Location = new Point(165, 153);
            decvalvenda.Name = "decvalvenda";
            decvalvenda.Size = new Size(453, 25);
            decvalvenda.TabIndex = 20;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(21, 154);
            label23.Name = "label23";
            label23.Size = new Size(116, 20);
            label23.TabIndex = 19;
            label23.Text = "Valor da venda:";
            label23.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtnomecomp
            // 
            txtnomecomp.Location = new Point(165, 100);
            txtnomecomp.Name = "txtnomecomp";
            txtnomecomp.Size = new Size(453, 25);
            txtnomecomp.TabIndex = 16;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(56, 73);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(0, 25);
            maskedTextBox4.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 101);
            label10.Name = "label10";
            label10.Size = new Size(138, 20);
            label10.TabIndex = 14;
            label10.Text = "Nome Comprador:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(gridmarcas);
            tabPage5.Controls.Add(button4);
            tabPage5.Controls.Add(label21);
            tabPage5.Controls.Add(button2);
            tabPage5.Controls.Add(txtmarca);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label6);
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(652, 279);
            tabPage5.TabIndex = 3;
            tabPage5.Text = "Marcas";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(453, 237);
            button4.Name = "button4";
            button4.Size = new Size(100, 33);
            button4.TabIndex = 6;
            button4.Text = "Deletar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Javanese Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(403, 19);
            label21.Name = "label21";
            label21.Size = new Size(197, 45);
            label21.TabIndex = 5;
            label21.Text = "Marcas no sistema";
            // 
            // gridmarcas
            // 
            gridmarcas.BackgroundColor = Color.WhiteSmoke;
            gridmarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridmarcas.Location = new Point(430, 51);
            gridmarcas.Name = "gridmarcas";
            gridmarcas.Size = new Size(144, 180);
            gridmarcas.TabIndex = 4;
            gridmarcas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(149, 160);
            button2.Name = "button2";
            button2.Size = new Size(100, 33);
            button2.TabIndex = 3;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(79, 103);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(270, 25);
            txtmarca.TabIndex = 2;
            txtmarca.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 104);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 1;
            label8.Text = "Marca:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Javanese Text", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(93, 19);
            label6.Name = "label6";
            label6.Size = new Size(225, 45);
            label6.TabIndex = 0;
            label6.Text = "Adicione suas marcas";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(txtcomprador);
            tabPage4.Controls.Add(gridvendas);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(652, 279);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "Vendas";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(519, 30);
            button8.Name = "button8";
            button8.Size = new Size(100, 33);
            button8.TabIndex = 10;
            button8.Text = "Deletar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(33, 29);
            label25.Name = "label25";
            label25.Size = new Size(92, 20);
            label25.TabIndex = 9;
            label25.Text = "Comprador:";
            label25.Click += label25_Click;
            // 
            // txtcomprador
            // 
            txtcomprador.Location = new Point(131, 28);
            txtcomprador.Name = "txtcomprador";
            txtcomprador.Size = new Size(178, 25);
            txtcomprador.TabIndex = 8;
            txtcomprador.TextChanged += txtcomprador_TextChanged;
            // 
            // gridvendas
            // 
            gridvendas.BackgroundColor = Color.WhiteSmoke;
            gridvendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridvendas.Location = new Point(33, 69);
            gridvendas.Name = "gridvendas";
            gridvendas.Size = new Size(586, 188);
            gridvendas.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.LightGray;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.FromArgb(11, 19, 43);
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.Black;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(169, 179, 206);
            linkLabel1.Location = new Point(13, 72);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(108, 43);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastrar";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.LightGray;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.FromArgb(11, 19, 43);
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = Color.Black;
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(169, 179, 206);
            linkLabel2.Location = new Point(13, 130);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(81, 43);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Buscar";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.LightGray;
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.FromArgb(11, 19, 43);
            linkLabel3.Cursor = Cursors.Hand;
            linkLabel3.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel3.ForeColor = Color.Black;
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkColor = Color.FromArgb(169, 179, 206);
            linkLabel3.Location = new Point(13, 186);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(85, 43);
            linkLabel3.TabIndex = 8;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Marcas";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(11, 19, 43);
            pictureBox1.Location = new Point(-8, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 382);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(169, 179, 206);
            pictureBox2.Location = new Point(138, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(660, 375);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // linkLabel4
            // 
            linkLabel4.ActiveLinkColor = Color.LightGray;
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.FromArgb(11, 19, 43);
            linkLabel4.Cursor = Cursors.Hand;
            linkLabel4.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel4.ForeColor = Color.Black;
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel4.LinkColor = Color.FromArgb(169, 179, 206);
            linkLabel4.Location = new Point(13, 246);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(84, 43);
            linkLabel4.TabIndex = 9;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Vendas";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked_1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(169, 179, 206);
            label22.Font = new Font("Javanese Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(11, 19, 43);
            label22.Location = new Point(362, 15);
            label22.Name = "label22";
            label22.Size = new Size(208, 54);
            label22.TabIndex = 10;
            label22.Text = "Revendedora LL";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(799, 380);
            Controls.Add(label22);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de veículos";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridveiculos).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridmarcas).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridvendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label Placa;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtplaca;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox intano;
        private TextBox txtmodelo;
        private ComboBox intmarca;
        private Label label7;
        private TextBox decvalor;
        private Button botaoCadastro;
        private TextBox txtcor;
        private TabPage tabPage5;
        private Label label6;
        private Button button2;
        private TextBox txtmarca;
        private Label label8;
        private Button button3;
        private TextBox txtbusca;
        private DataGridView gridveiculos;
        private TabPage tabPage3;
        private TextBox txtalteracor;
        private Label label16;
        private TextBox decalteravalor;
        private TextBox intalteraano;
        private TextBox txtalteramodelo;
        private TextBox txtalteraplaca;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button button5;
        private ComboBox intalteramarca;
        private Label label17;
        private Button button6;
        private Button button7;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label19;
        private Label label18;
        private TextBox txtbuscamarca;
        private TextBox txtbuscacor;
        private TextBox txtbuscamodelo;
        private Label label9;
        private Label label20;
        private Label label21;
        private DataGridView gridmarcas;
        private Button botaovender;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TabPage tabPage6;
        private TextBox txtnomecomp;
        private MaskedTextBox maskedTextBox4;
        private Label label10;
        private TabPage tabPage4;
        private Label label24;
        private Button button1;
        private TextBox decvalvenda;
        private Label label23;
        private LinkLabel linkLabel4;
        private Label label25;
        private TextBox txtcomprador;
        private DataGridView gridvendas;
        private Button button4;
        private Button button8;
        private Label label22;
    }
}
