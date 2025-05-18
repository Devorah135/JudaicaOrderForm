namespace FinalProject
{
    partial class BalanceForm
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
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.lbl_Pay = new System.Windows.Forms.Label();
            this.payment_amt = new System.Windows.Forms.NumericUpDown();
            this.lbl_BalanceStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payment_amt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("Levenim MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.Location = new System.Drawing.Point(408, 126);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(0, 27);
            this.lbl_Balance.TabIndex = 15;
            this.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.label1.Location = new System.Drawing.Point(286, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your Account Balance:";
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Pay.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.btn_Pay.Location = new System.Drawing.Point(327, 300);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(167, 56);
            this.btn_Pay.TabIndex = 18;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // lbl_Pay
            // 
            this.lbl_Pay.AutoSize = true;
            this.lbl_Pay.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.lbl_Pay.Location = new System.Drawing.Point(243, 194);
            this.lbl_Pay.Name = "lbl_Pay";
            this.lbl_Pay.Size = new System.Drawing.Size(347, 27);
            this.lbl_Pay.TabIndex = 19;
            this.lbl_Pay.Text = "How much would you like to pay?";
            // 
            // payment_amt
            // 
            this.payment_amt.DecimalPlaces = 2;
            this.payment_amt.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.payment_amt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.payment_amt.Location = new System.Drawing.Point(350, 240);
            this.payment_amt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.payment_amt.Name = "payment_amt";
            this.payment_amt.Size = new System.Drawing.Size(126, 35);
            this.payment_amt.TabIndex = 20;
            this.payment_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.payment_amt.ThousandsSeparator = true;
            // 
            // lbl_BalanceStatus
            // 
            this.lbl_BalanceStatus.AutoSize = true;
            this.lbl_BalanceStatus.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.lbl_BalanceStatus.Location = new System.Drawing.Point(147, 383);
            this.lbl_BalanceStatus.Name = "lbl_BalanceStatus";
            this.lbl_BalanceStatus.Size = new System.Drawing.Size(0, 27);
            this.lbl_BalanceStatus.TabIndex = 21;
            this.lbl_BalanceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_BalanceStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_BalanceStatus);
            this.Controls.Add(this.payment_amt);
            this.Controls.Add(this.lbl_Pay);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Balance);
            this.Name = "BalanceForm";
            this.Text = "BalanceForm";
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment_amt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbl_Pay;
        private System.Windows.Forms.NumericUpDown payment_amt;
        private System.Windows.Forms.Label lbl_BalanceStatus;
    }
}