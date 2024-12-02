namespace MarketApp
{
    partial class SignUp
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
            fullnameSignup = new TextBox();
            label3 = new Label();
            gmailSignup = new TextBox();
            label4 = new Label();
            passwordSignup = new TextBox();
            SignupButton = new Button();
            Home = new Button();
            Seller = new RadioButton();
            Buyer = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(166, 69);
            label1.Name = "label1";
            label1.Size = new Size(130, 41);
            label1.TabIndex = 1;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(39, 165);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // fullnameSignup
            // 
            fullnameSignup.Location = new Point(39, 215);
            fullnameSignup.Name = "fullnameSignup";
            fullnameSignup.Size = new Size(368, 27);
            fullnameSignup.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(39, 268);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 4;
            label3.Text = "Gmail";
            // 
            // gmailSignup
            // 
            gmailSignup.Location = new Point(39, 325);
            gmailSignup.Name = "gmailSignup";
            gmailSignup.Size = new Size(368, 27);
            gmailSignup.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(39, 376);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // passwordSignup
            // 
            passwordSignup.Location = new Point(39, 425);
            passwordSignup.Name = "passwordSignup";
            passwordSignup.Size = new Size(368, 27);
            passwordSignup.TabIndex = 7;
            // 
            // SignupButton
            // 
            SignupButton.BackColor = Color.Red;
            SignupButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            SignupButton.ForeColor = Color.White;
            SignupButton.Location = new Point(56, 565);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(148, 58);
            SignupButton.TabIndex = 8;
            SignupButton.Text = "Sign Up";
            SignupButton.UseVisualStyleBackColor = false;
            SignupButton.Click += SignupButton_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.Red;
            Home.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Home.ForeColor = Color.White;
            Home.Location = new Point(238, 565);
            Home.Name = "Home";
            Home.Size = new Size(148, 58);
            Home.TabIndex = 9;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // Seller
            // 
            Seller.AutoSize = true;
            Seller.Location = new Point(94, 494);
            Seller.Name = "Seller";
            Seller.Size = new Size(67, 24);
            Seller.TabIndex = 10;
            Seller.TabStop = true;
            Seller.Text = "Seller";
            Seller.UseVisualStyleBackColor = true;
            // 
            // Buyer
            // 
            Buyer.AutoSize = true;
            Buyer.Location = new Point(219, 494);
            Buyer.Name = "Buyer";
            Buyer.Size = new Size(67, 24);
            Buyer.TabIndex = 11;
            Buyer.TabStop = true;
            Buyer.Text = "Buyer";
            Buyer.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(493, 711);
            Controls.Add(Buyer);
            Controls.Add(Seller);
            Controls.Add(Home);
            Controls.Add(SignupButton);
            Controls.Add(passwordSignup);
            Controls.Add(label4);
            Controls.Add(gmailSignup);
            Controls.Add(label3);
            Controls.Add(fullnameSignup);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox fullnameSignup;
        private Label label3;
        private TextBox gmailSignup;
        private Label label4;
        private TextBox passwordSignup;
        private Button SignupButton;
        private Button Home;
        private RadioButton Seller;
        private RadioButton Buyer;
    }
}