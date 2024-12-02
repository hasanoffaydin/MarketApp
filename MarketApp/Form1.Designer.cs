namespace MarketApp
{
    partial class Log
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
            label1 = new Label();
            label2 = new Label();
            usernameLogin = new TextBox();
            label3 = new Label();
            passwordLogin = new TextBox();
            login = new Button();
            signup = new Button();
            Seller = new RadioButton();
            Buyer = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(132, 77);
            label1.Name = "label1";
            label1.Size = new Size(184, 41);
            label1.TabIndex = 0;
            label1.Text = "Seller Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(30, 154);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // usernameLogin
            // 
            usernameLogin.Location = new Point(30, 205);
            usernameLogin.Name = "usernameLogin";
            usernameLogin.Size = new Size(368, 27);
            usernameLogin.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(30, 261);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // passwordLogin
            // 
            passwordLogin.Location = new Point(30, 319);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(368, 27);
            passwordLogin.TabIndex = 4;
            // 
            // login
            // 
            login.BackColor = Color.Blue;
            login.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            login.ForeColor = Color.White;
            login.Location = new Point(47, 450);
            login.Name = "login";
            login.Size = new Size(148, 58);
            login.TabIndex = 5;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // signup
            // 
            signup.BackColor = Color.Red;
            signup.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            signup.ForeColor = Color.White;
            signup.Location = new Point(225, 450);
            signup.Name = "signup";
            signup.Size = new Size(148, 58);
            signup.TabIndex = 6;
            signup.Text = "Sign Up";
            signup.UseVisualStyleBackColor = false;
            signup.Click += signup_Click;
            // 
            // Seller
            // 
            Seller.AutoSize = true;
            Seller.Location = new Point(91, 388);
            Seller.Name = "Seller";
            Seller.Size = new Size(67, 24);
            Seller.TabIndex = 11;
            Seller.TabStop = true;
            Seller.Text = "Seller";
            Seller.UseVisualStyleBackColor = true;
            // 
            // Buyer
            // 
            Buyer.AutoSize = true;
            Buyer.Location = new Point(213, 388);
            Buyer.Name = "Buyer";
            Buyer.Size = new Size(67, 24);
            Buyer.TabIndex = 12;
            Buyer.TabStop = true;
            Buyer.Text = "Buyer";
            Buyer.UseVisualStyleBackColor = true;
            // 
            // Log
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(436, 570);
            Controls.Add(Buyer);
            Controls.Add(Seller);
            Controls.Add(signup);
            Controls.Add(login);
            Controls.Add(passwordLogin);
            Controls.Add(label3);
            Controls.Add(usernameLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Log";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameLogin;
        private Label label3;
        private TextBox passwordLogin;
        private Button login;
        private Button signup;
        private RadioButton Seller;
        private RadioButton Buyer;
    }
}
