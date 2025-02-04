namespace Revendedora
{
    partial class Login
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
            label2 = new Label();
            txtemail = new TextBox();
            txtsenha = new TextBox();
            button1 = new Button();
            label3 = new Label();
            linkcadastro = new LinkLabel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(169, 179, 206);
            pictureBox1.Location = new Point(210, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 368);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(169, 179, 206);
            pictureBox2.Image = Properties.Resources.png_transparent_login_computer_icons_avatar_icon_monochrome_black_silhouette_thumbnail__1_;
            pictureBox2.Location = new Point(318, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(144, 143);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(169, 179, 206);
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 235);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(169, 179, 206);
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 273);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            label2.Click += label2_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(274, 236);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(272, 23);
            txtemail.TabIndex = 4;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(274, 274);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(272, 23);
            txtsenha.TabIndex = 5;
            txtsenha.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(328, 320);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 6;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(169, 179, 206);
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 357);
            label3.Name = "label3";
            label3.Size = new Size(123, 17);
            label3.TabIndex = 13;
            label3.Text = "Não tem cadastro?";
            // 
            // linkcadastro
            // 
            linkcadastro.AutoSize = true;
            linkcadastro.BackColor = Color.FromArgb(169, 179, 206);
            linkcadastro.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkcadastro.Location = new Point(352, 374);
            linkcadastro.Name = "linkcadastro";
            linkcadastro.Size = new Size(79, 17);
            linkcadastro.TabIndex = 15;
            linkcadastro.TabStop = true;
            linkcadastro.Text = "Cadastre-se";
            linkcadastro.LinkClicked += linkcadastro_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(169, 179, 206);
            label4.Font = new Font("Javanese Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(352, 45);
            label4.Name = "label4";
            label4.Size = new Size(87, 54);
            label4.TabIndex = 16;
            label4.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 19, 43);
            ClientSize = new Size(783, 429);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(linkcadastro);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtsenha);
            Controls.Add(txtemail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox txtemail;
        private TextBox txtsenha;
        private Button button1;
        private Label label3;
        private LinkLabel linkcadastro;
        private Label label4;
    }
}