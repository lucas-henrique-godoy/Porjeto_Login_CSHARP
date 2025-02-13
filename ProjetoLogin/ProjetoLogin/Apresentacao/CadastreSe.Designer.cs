namespace ProjetoLogin.Apresentacao
{
    partial class CadastreSe
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txbLogin = new TextBox();
            txbSenha = new TextBox();
            txbConfirmarSenha = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 12F);
            label1.Location = new Point(77, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 12F);
            label2.Location = new Point(77, 106);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 12F);
            label3.Location = new Point(77, 196);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 2;
            label3.Text = "Confirmar Senha";
            // 
            // txbLogin
            // 
            txbLogin.BackColor = SystemColors.Control;
            txbLogin.Location = new Point(77, 63);
            txbLogin.Name = "txbLogin";
            txbLogin.Size = new Size(265, 23);
            txbLogin.TabIndex = 3;
            // 
            // txbSenha
            // 
            txbSenha.BackColor = SystemColors.Control;
            txbSenha.Font = new Font("Segoe UI", 10F);
            txbSenha.Location = new Point(75, 135);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new Size(174, 25);
            txbSenha.TabIndex = 4;
            // 
            // txbConfirmarSenha
            // 
            txbConfirmarSenha.BackColor = SystemColors.Control;
            txbConfirmarSenha.Font = new Font("Segoe UI", 10F);
            txbConfirmarSenha.Location = new Point(76, 225);
            txbConfirmarSenha.Name = "txbConfirmarSenha";
            txbConfirmarSenha.PasswordChar = '*';
            txbConfirmarSenha.Size = new Size(173, 25);
            txbConfirmarSenha.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.Control;
            btnCadastrar.Location = new Point(151, 293);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(98, 39);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // CadastreSe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(399, 361);
            Controls.Add(btnCadastrar);
            Controls.Add(txbConfirmarSenha);
            Controls.Add(txbSenha);
            Controls.Add(txbLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CadastreSe";
            Text = "CadastreSe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbLogin;
        private TextBox txbSenha;
        private TextBox txbConfirmarSenha;
        private Button btnCadastrar;
    }
}