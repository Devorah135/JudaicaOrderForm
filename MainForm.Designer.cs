namespace FinalProject
{
    partial class MainForm
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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_viewBalance = new System.Windows.Forms.Button();
            this.btn_viewPurchases = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.lbl_chooseOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.lbl_Welcome.Location = new System.Drawing.Point(287, 29);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(117, 27);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome, ";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_viewBalance
            // 
            this.btn_viewBalance.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.btn_viewBalance.Location = new System.Drawing.Point(69, 134);
            this.btn_viewBalance.Name = "btn_viewBalance";
            this.btn_viewBalance.Size = new System.Drawing.Size(259, 81);
            this.btn_viewBalance.TabIndex = 8;
            this.btn_viewBalance.Text = "View and Pay Account Balance";
            this.btn_viewBalance.UseVisualStyleBackColor = true;
            this.btn_viewBalance.Click += new System.EventHandler(this.btn_viewBalance_Click);
            // 
            // btn_viewPurchases
            // 
            this.btn_viewPurchases.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.btn_viewPurchases.Location = new System.Drawing.Point(69, 230);
            this.btn_viewPurchases.Name = "btn_viewPurchases";
            this.btn_viewPurchases.Size = new System.Drawing.Size(259, 81);
            this.btn_viewPurchases.TabIndex = 9;
            this.btn_viewPurchases.Text = "View Purchase History";
            this.btn_viewPurchases.UseVisualStyleBackColor = true;
            this.btn_viewPurchases.Click += new System.EventHandler(this.btn_viewPurchases_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Tomato;
            this.btn_logout.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.btn_logout.Location = new System.Drawing.Point(359, 230);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(259, 81);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_purchase
            // 
            this.btn_purchase.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.btn_purchase.Location = new System.Drawing.Point(359, 134);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(259, 81);
            this.btn_purchase.TabIndex = 11;
            this.btn_purchase.Text = "View Items and Order";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // lbl_chooseOption
            // 
            this.lbl_chooseOption.AutoSize = true;
            this.lbl_chooseOption.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.lbl_chooseOption.Location = new System.Drawing.Point(176, 86);
            this.lbl_chooseOption.Name = "lbl_chooseOption";
            this.lbl_chooseOption.Size = new System.Drawing.Size(348, 27);
            this.lbl_chooseOption.TabIndex = 12;
            this.lbl_chooseOption.Text = "Choose one of the options below:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 420);
            this.Controls.Add(this.lbl_chooseOption);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_viewPurchases);
            this.Controls.Add(this.btn_viewBalance);
            this.Controls.Add(this.lbl_Welcome);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btn_viewBalance;
        private System.Windows.Forms.Button btn_viewPurchases;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Label lbl_chooseOption;
    }
}