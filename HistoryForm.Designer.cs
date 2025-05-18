namespace FinalProject
{
    partial class HistoryForm
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
            this.lst_PurchaseHistory = new System.Windows.Forms.ListView();
            this.lbl_PurchaseHistory = new System.Windows.Forms.Label();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_FromDate = new System.Windows.Forms.Label();
            this.lbl_ToDate = new System.Windows.Forms.Label();
            this.dtp_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.num_MinPrice = new System.Windows.Forms.NumericUpDown();
            this.num_MaxPrice = new System.Windows.Forms.NumericUpDown();
            this.btn_ApplyFilters = new System.Windows.Forms.Button();
            this.btn_ClearFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_MinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_PurchaseHistory
            // 
            this.lst_PurchaseHistory.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.lst_PurchaseHistory.FullRowSelect = true;
            this.lst_PurchaseHistory.GridLines = true;
            this.lst_PurchaseHistory.HideSelection = false;
            this.lst_PurchaseHistory.Location = new System.Drawing.Point(243, 72);
            this.lst_PurchaseHistory.Name = "lst_PurchaseHistory";
            this.lst_PurchaseHistory.Size = new System.Drawing.Size(670, 354);
            this.lst_PurchaseHistory.TabIndex = 1;
            this.lst_PurchaseHistory.UseCompatibleStateImageBehavior = false;
            this.lst_PurchaseHistory.View = System.Windows.Forms.View.Details;
            this.lst_PurchaseHistory.SelectedIndexChanged += new System.EventHandler(this.lst_PurchaseHistory_SelectedIndexChanged);
            // 
            // lbl_PurchaseHistory
            // 
            this.lbl_PurchaseHistory.AutoSize = true;
            this.lbl_PurchaseHistory.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.lbl_PurchaseHistory.Location = new System.Drawing.Point(325, 26);
            this.lbl_PurchaseHistory.Name = "lbl_PurchaseHistory";
            this.lbl_PurchaseHistory.Size = new System.Drawing.Size(172, 27);
            this.lbl_PurchaseHistory.TabIndex = 2;
            this.lbl_PurchaseHistory.Text = "Purchase History";
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.lbl_Filter.Location = new System.Drawing.Point(17, 72);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(120, 21);
            this.lbl_Filter.TabIndex = 3;
            this.lbl_Filter.Text = "Choose Filters:";
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.CalendarFont = new System.Drawing.Font("Levenim MT", 8F);
            this.dtp_FromDate.CustomFormat = "mm/dd/yyyy";
            this.dtp_FromDate.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.dtp_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FromDate.Location = new System.Drawing.Point(75, 154);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(141, 30);
            this.dtp_FromDate.TabIndex = 4;
            this.dtp_FromDate.Value = new System.DateTime(2025, 5, 18, 18, 25, 42, 0);
            // 
            // lbl_FromDate
            // 
            this.lbl_FromDate.AutoSize = true;
            this.lbl_FromDate.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.lbl_FromDate.Location = new System.Drawing.Point(17, 161);
            this.lbl_FromDate.Name = "lbl_FromDate";
            this.lbl_FromDate.Size = new System.Drawing.Size(52, 21);
            this.lbl_FromDate.TabIndex = 5;
            this.lbl_FromDate.Text = "From:";
            // 
            // lbl_ToDate
            // 
            this.lbl_ToDate.AutoSize = true;
            this.lbl_ToDate.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.lbl_ToDate.Location = new System.Drawing.Point(33, 204);
            this.lbl_ToDate.Name = "lbl_ToDate";
            this.lbl_ToDate.Size = new System.Drawing.Size(31, 21);
            this.lbl_ToDate.TabIndex = 6;
            this.lbl_ToDate.Text = "To:";
            // 
            // dtp_ToDate
            // 
            this.dtp_ToDate.CalendarFont = new System.Drawing.Font("Levenim MT", 8F);
            this.dtp_ToDate.CustomFormat = "mm/dd/yyyy";
            this.dtp_ToDate.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.dtp_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ToDate.Location = new System.Drawing.Point(75, 197);
            this.dtp_ToDate.Name = "dtp_ToDate";
            this.dtp_ToDate.Size = new System.Drawing.Size(141, 30);
            this.dtp_ToDate.TabIndex = 7;
            this.dtp_ToDate.Value = new System.DateTime(2025, 5, 18, 18, 25, 50, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.label1.Location = new System.Drawing.Point(50, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter by Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.label2.Location = new System.Drawing.Point(50, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter by Price";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.lbl_min.Location = new System.Drawing.Point(27, 287);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(42, 21);
            this.lbl_min.TabIndex = 10;
            this.lbl_min.Text = "Min:";
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.lbl_Max.Location = new System.Drawing.Point(21, 329);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(48, 21);
            this.lbl_Max.TabIndex = 11;
            this.lbl_Max.Text = "Max:";
            // 
            // num_MinPrice
            // 
            this.num_MinPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_MinPrice.DecimalPlaces = 2;
            this.num_MinPrice.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.num_MinPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_MinPrice.Location = new System.Drawing.Point(75, 282);
            this.num_MinPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_MinPrice.Name = "num_MinPrice";
            this.num_MinPrice.Size = new System.Drawing.Size(141, 30);
            this.num_MinPrice.TabIndex = 12;
            this.num_MinPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_MinPrice.ThousandsSeparator = true;
            // 
            // num_MaxPrice
            // 
            this.num_MaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_MaxPrice.DecimalPlaces = 2;
            this.num_MaxPrice.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.num_MaxPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_MaxPrice.Location = new System.Drawing.Point(75, 324);
            this.num_MaxPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_MaxPrice.Name = "num_MaxPrice";
            this.num_MaxPrice.Size = new System.Drawing.Size(141, 30);
            this.num_MaxPrice.TabIndex = 13;
            this.num_MaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_MaxPrice.ThousandsSeparator = true;
            // 
            // btn_ApplyFilters
            // 
            this.btn_ApplyFilters.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ApplyFilters.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.btn_ApplyFilters.Location = new System.Drawing.Point(25, 374);
            this.btn_ApplyFilters.Name = "btn_ApplyFilters";
            this.btn_ApplyFilters.Size = new System.Drawing.Size(112, 72);
            this.btn_ApplyFilters.TabIndex = 14;
            this.btn_ApplyFilters.Text = "Apply Filters";
            this.btn_ApplyFilters.UseVisualStyleBackColor = false;
            this.btn_ApplyFilters.Click += new System.EventHandler(this.btn_ApplyFilters_Click);
            // 
            // btn_ClearFilters
            // 
            this.btn_ClearFilters.BackColor = System.Drawing.Color.Tomato;
            this.btn_ClearFilters.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.btn_ClearFilters.Location = new System.Drawing.Point(143, 374);
            this.btn_ClearFilters.Name = "btn_ClearFilters";
            this.btn_ClearFilters.Size = new System.Drawing.Size(73, 72);
            this.btn_ClearFilters.TabIndex = 15;
            this.btn_ClearFilters.Text = "Clear Filters";
            this.btn_ClearFilters.UseVisualStyleBackColor = false;
            this.btn_ClearFilters.Click += new System.EventHandler(this.btn_ClearFilters_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 458);
            this.Controls.Add(this.btn_ClearFilters);
            this.Controls.Add(this.btn_ApplyFilters);
            this.Controls.Add(this.num_MaxPrice);
            this.Controls.Add(this.num_MinPrice);
            this.Controls.Add(this.lbl_Max);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_ToDate);
            this.Controls.Add(this.lbl_ToDate);
            this.Controls.Add(this.lbl_FromDate);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.lbl_PurchaseHistory);
            this.Controls.Add(this.lst_PurchaseHistory);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_MinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_MaxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_PurchaseHistory;
        private System.Windows.Forms.Label lbl_PurchaseHistory;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.Label lbl_FromDate;
        private System.Windows.Forms.Label lbl_ToDate;
        private System.Windows.Forms.DateTimePicker dtp_ToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.NumericUpDown num_MinPrice;
        private System.Windows.Forms.NumericUpDown num_MaxPrice;
        private System.Windows.Forms.Button btn_ApplyFilters;
        private System.Windows.Forms.Button btn_ClearFilters;
    }
}