namespace ventana_menu
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
            login = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(383, 321);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 0;
            login.Text = "button1";
            login.UseVisualStyleBackColor = true;
            login.Click += btnLogin_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(379, 66);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "usuario";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(342, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "contraseña";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(808, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private TextBox txtUsuario;
        private TextBox txtPassword;
    }
}
