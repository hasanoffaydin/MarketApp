namespace MarketApp
{
    partial class ForBuyer
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            listBox1 = new ListBox();
            totalAmount = new Label();
            Pay = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(622, 462);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(652, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(362, 384);
            listBox1.TabIndex = 1;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            totalAmount.Location = new Point(683, 424);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(26, 30);
            totalAmount.TabIndex = 2;
            totalAmount.Text = "0";
            // 
            // Pay
            // 
            Pay.BackColor = Color.Green;
            Pay.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Pay.ForeColor = Color.White;
            Pay.Location = new Point(870, 487);
            Pay.Name = "Pay";
            Pay.Size = new Size(129, 53);
            Pay.TabIndex = 3;
            Pay.Text = "Pay";
            Pay.UseVisualStyleBackColor = false;
            Pay.Click += Pay_Click;
            // 
            // ForBuyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1025, 552);
            Controls.Add(Pay);
            Controls.Add(totalAmount);
            Controls.Add(listBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "ForBuyer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForBuyer";
            Load += ForBuyer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox listBox1;
        private Label totalAmount;
        private Button Pay;
    }
}