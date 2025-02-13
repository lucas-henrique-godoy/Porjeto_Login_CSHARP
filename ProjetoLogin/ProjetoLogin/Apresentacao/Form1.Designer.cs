namespace ProjetoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblLogin = new Label();
            lblSenha = new Label();
            txbLogin = new TextBox();
            txbSenha = new TextBox();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            btnSair = new Button();
            btnCadastreSe = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Calisto MT", 14.25F);
            lblLogin.Location = new Point(293, 82);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(75, 22);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "LOGIN";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Calisto MT", 14.25F);
            lblSenha.Location = new Point(293, 128);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(78, 22);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "SENHA";
            // 
            // txbLogin
            // 
            txbLogin.BackColor = SystemColors.Control;
            txbLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbLogin.Location = new Point(382, 81);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(185, 22);
            txbLogin.TabIndex = 4;
            // 
            // txbSenha
            // 
            txbSenha.BackColor = SystemColors.Control;
            txbSenha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbSenha.Location = new Point(382, 127);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(185, 22);
            txbSenha.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.Control;
            btnEntrar.Location = new Point(393, 181);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.Control;
            btnSair.Location = new Point(492, 181);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // btnCadastreSe
            // 
            btnCadastreSe.BackColor = SystemColors.Control;
            btnCadastreSe.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastreSe.Location = new Point(443, 231);
            btnCadastreSe.Name = "btnCadastreSe";
            btnCadastreSe.Size = new Size(124, 40);
            btnCadastreSe.TabIndex = 9;
            btnCadastreSe.Text = "CADASTRE-SE";
            btnCadastreSe.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(614, 298);
            Controls.Add(btnCadastreSe);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Controls.Add(txbSenha);
            Controls.Add(txbLogin);
            Controls.Add(lblSenha);
            Controls.Add(lblLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txbLogin;
        private TextBox txbSenha;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button btnSair;
        private Button btnCadastreSe;
    }
}
