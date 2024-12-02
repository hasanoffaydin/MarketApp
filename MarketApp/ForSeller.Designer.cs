namespace MarketApp
{
    partial class ForSeller
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
            label2 = new Label();
            productName = new TextBox();
            label1 = new Label();
            productPrice = new TextBox();
            label3 = new Label();
            productQuantity = new TextBox();
            label4 = new Label();
            purchasePrice = new TextBox();
            AddProduct = new Button();
            melumatlar = new DataGridView();
            Home = new Button();
            ShowAllData = new Button();
            ((System.ComponentModel.ISupportInitialize)melumatlar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(41, 41);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
            label2.TabIndex = 3;
            label2.Text = "Product Name";
            // 
            // productName
            // 
            productName.Location = new Point(258, 47);
            productName.Name = "productName";
            productName.Size = new Size(368, 27);
            productName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(41, 115);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 5;
            label1.Text = "Product Price";
            // 
            // productPrice
            // 
            productPrice.Location = new Point(258, 121);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(368, 27);
            productPrice.TabIndex = 6;
            productPrice.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(25, 188);
            label3.Name = "label3";
            label3.Size = new Size(211, 32);
            label3.TabIndex = 7;
            label3.Text = "Product Quantity";
            // 
            // productQuantity
            // 
            productQuantity.Location = new Point(258, 194);
            productQuantity.Name = "productQuantity";
            productQuantity.Size = new Size(368, 27);
            productQuantity.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(41, 252);
            label4.Name = "label4";
            label4.Size = new Size(181, 32);
            label4.TabIndex = 9;
            label4.Text = "Purchase Price";
            // 
            // purchasePrice
            // 
            purchasePrice.Location = new Point(258, 258);
            purchasePrice.Name = "purchasePrice";
            purchasePrice.Size = new Size(368, 27);
            purchasePrice.TabIndex = 10;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.Green;
            AddProduct.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            AddProduct.ForeColor = Color.White;
            AddProduct.Location = new Point(166, 331);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(188, 54);
            AddProduct.TabIndex = 11;
            AddProduct.Text = "Add Product";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // melumatlar
            // 
            melumatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            melumatlar.Location = new Point(753, 41);
            melumatlar.Name = "melumatlar";
            melumatlar.RowHeadersWidth = 51;
            melumatlar.Size = new Size(862, 244);
            melumatlar.TabIndex = 12;
            // 
            // Home
            // 
            Home.BackColor = Color.Blue;
            Home.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Home.ForeColor = Color.White;
            Home.Location = new Point(417, 331);
            Home.Name = "Home";
            Home.Size = new Size(188, 54);
            Home.TabIndex = 13;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // ShowAllData
            // 
            ShowAllData.BackColor = Color.Blue;
            ShowAllData.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            ShowAllData.ForeColor = Color.White;
            ShowAllData.Location = new Point(780, 331);
            ShowAllData.Name = "ShowAllData";
            ShowAllData.Size = new Size(188, 54);
            ShowAllData.TabIndex = 14;
            ShowAllData.Text = "ShowAllData";
            ShowAllData.UseVisualStyleBackColor = false;
            ShowAllData.Click += ShowAllData_Click;
            // 
            // ForSeller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1659, 450);
            Controls.Add(ShowAllData);
            Controls.Add(Home);
            Controls.Add(melumatlar);
            Controls.Add(AddProduct);
            Controls.Add(purchasePrice);
            Controls.Add(label4);
            Controls.Add(productQuantity);
            Controls.Add(label3);
            Controls.Add(productPrice);
            Controls.Add(label1);
            Controls.Add(productName);
            Controls.Add(label2);
            Name = "ForSeller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForSeller";
            ((System.ComponentModel.ISupportInitialize)melumatlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox productName;
        private Label label1;
        private TextBox productPrice;
        private Label label3;
        private TextBox productQuantity;
        private Label label4;
        private TextBox purchasePrice;
        private Button AddProduct;
        private DataGridView melumatlar;
        private Button Home;
        private Button ShowAllData;
    }
}