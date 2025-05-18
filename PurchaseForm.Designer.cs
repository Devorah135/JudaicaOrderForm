namespace FinalProject
{
    partial class PurchaseForm
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
            this.purchase_status = new System.Windows.Forms.Label();
            this.btn_purchase = new System.Windows.Forms.Button();
            this.quantity_chooser = new System.Windows.Forms.NumericUpDown();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_choose = new System.Windows.Forms.Label();
            this.Item_choice_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_chooser)).BeginInit();
            this.SuspendLayout();
            // 
            // purchase_status
            // 
            this.purchase_status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.purchase_status.AutoEllipsis = true;
            this.purchase_status.AutoSize = true;
            this.purchase_status.Font = new System.Drawing.Font("Levenim MT", 9F);
            this.purchase_status.Location = new System.Drawing.Point(368, 321);
            this.purchase_status.Name = "purchase_status";
            this.purchase_status.Size = new System.Drawing.Size(59, 24);
            this.purchase_status.TabIndex = 13;
            this.purchase_status.Text = "status";
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_purchase.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.btn_purchase.Location = new System.Drawing.Point(248, 228);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(311, 64);
            this.btn_purchase.TabIndex = 12;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // quantity_chooser
            // 
            this.quantity_chooser.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.quantity_chooser.Location = new System.Drawing.Point(364, 172);
            this.quantity_chooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity_chooser.Name = "quantity_chooser";
            this.quantity_chooser.Size = new System.Drawing.Size(73, 35);
            this.quantity_chooser.TabIndex = 11;
            this.quantity_chooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.lbl_quantity.Location = new System.Drawing.Point(349, 136);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(101, 27);
            this.lbl_quantity.TabIndex = 10;
            this.lbl_quantity.Text = "Quantity:";
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Levenim MT", 10F);
            this.lbl_choose.Location = new System.Drawing.Point(312, 43);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(175, 27);
            this.lbl_choose.TabIndex = 9;
            this.lbl_choose.Text = "Choose an item:";
            // 
            // Item_choice_box
            // 
            this.Item_choice_box.DisplayMember = "\"\"";
            this.Item_choice_box.DropDownHeight = 150;
            this.Item_choice_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_choice_box.DropDownWidth = 320;
            this.Item_choice_box.Font = new System.Drawing.Font("Levenim MT", 8F);
            this.Item_choice_box.FormattingEnabled = true;
            this.Item_choice_box.IntegralHeight = false;
            this.Item_choice_box.ItemHeight = 21;
            this.Item_choice_box.Location = new System.Drawing.Point(219, 94);
            this.Item_choice_box.Name = "Item_choice_box";
            this.Item_choice_box.Size = new System.Drawing.Size(340, 29);
            this.Item_choice_box.Sorted = true;
            this.Item_choice_box.TabIndex = 8;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purchase_status);
            this.Controls.Add(this.btn_purchase);
            this.Controls.Add(this.quantity_chooser);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.Item_choice_box);
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity_chooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purchase_status;
        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.NumericUpDown quantity_chooser;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_choose;
        private System.Windows.Forms.ComboBox Item_choice_box;
    }
}