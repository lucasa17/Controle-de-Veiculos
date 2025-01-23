namespace Revendedora
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtnomeemp = new TextBox();
            txtemailemp = new TextBox();
            txtsenhaemp = new TextBox();
            button1 = new Button();
            label2 = new Label();
            linklogin = new LinkLabel();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(169, 179, 206);
            pictureBox1.Location = new Point(184, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 392);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(169, 179, 206);
            pictureBox2.Image = Properties.Resources.png_transparent_login_computer_icons_avatar_icon_monochrome_black_silhouette_thumbnail__1_;
            pictureBox2.Location = new Point(418, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 152);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(169, 179, 206);
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 209);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome da Empresa:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(169, 179, 206);
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(194, 254);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(169, 179, 206);
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(194, 297);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 6;
            label4.Text = "Senha:";
            // 
            // txtnomeemp
            // 
            txtnomeemp.Location = new Point(338, 210);
            txtnomeemp.Name = "txtnomeemp";
            txtnomeemp.Size = new Size(252, 23);
            txtnomeemp.TabIndex = 7;
            // 
            // txtemailemp
            // 
            txtemailemp.Location = new Point(250, 255);
            txtemailemp.Name = "txtemailemp";
            txtemailemp.Size = new Size(340, 23);
            txtemailemp.TabIndex = 9;
            // 
            // txtsenhaemp
            // 
            txtsenhaemp.Location = new Point(250, 298);
            txtsenhaemp.Name = "txtsenhaemp";
            txtsenhaemp.Size = new Size(340, 23);
            txtsenhaemp.TabIndex = 10;
            txtsenhaemp.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(324, 338);
            button1.Name = "button1";
            button1.Size = new Size(144, 34);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(169, 179, 206);
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(343, 375);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 12;
            label2.Text = "Já tem cadastro?";
            label2.Click += label2_Click;
            // 
            // linklogin
            // 
            linklogin.AutoSize = true;
            linklogin.BackColor = Color.FromArgb(169, 179, 206);
            linklogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linklogin.Location = new Point(374, 392);
            linklogin.Name = "linklogin";
            linklogin.Size = new Size(41, 17);
            linklogin.TabIndex = 13;
            linklogin.TabStop = true;
            linklogin.Text = "Login";
            linklogin.LinkClicked += linklogin_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(169, 179, 206);
            label5.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(274, 132);
            label5.Name = "label5";
            label5.Size = new Size(123, 29);
            label5.TabIndex = 14;
            label5.Text = "Cadastro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(169, 179, 206);
            label6.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(213, 79);
            label6.Name = "label6";
            label6.Size = new Size(119, 29);
            label6.TabIndex = 15;
            label6.Text = "Faça seu";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 19, 43);
            ClientSize = new Size(800, 429);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(linklogin);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtsenhaemp);
            Controls.Add(txtemailemp);
            Controls.Add(txtnomeemp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtnomeemp;
        private TextBox txtemailemp;
        private TextBox txtsenhaemp;
        private Button button1;
        private Label label2;
        private LinkLabel linklogin;
        private Label label5;
        private Label label6;
    }
}