using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class PurchaseForm : Form
    {
        private User currentUser;
        public PurchaseForm(User user)
        {
            InitializeComponent();
            currentUser = user;

        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            using (var db = new StoreDBDataContext())
            {
                var items = db.Items.ToList();

                Item_choice_box.DataSource = items;
            }

            quantity_chooser.Minimum = 1;
            quantity_chooser.Value = 1;
            purchase_status.Text = "";
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if(Item_choice_box.SelectedItem == null)
            {
                purchase_status.ForeColor = Color.Red;
                purchase_status.Text = "Please select an item.";
                return;
            }

            Item selectedItem = (Item)Item_choice_box.SelectedItem;
            int quantity = (int) quantity_chooser.Value;
            decimal totalPrice = selectedItem.Price * quantity;

            using (var db = new StoreDBDataContext())
            {
                var item = db.Items.First(i => i.ItemId == selectedItem.ItemId);
                var user = db.Users.First(u => u.UserId == currentUser.UserId);
                decimal total = item.Price * quantity;

                // limit to owe is 250
                if (user.Balance + total > 250)
                {
                    purchase_status.ForeColor = Color.Red;
                    purchase_status.Text = "Cannot buy, exceeded credit limit.";
                    purchase_status.Left = (this.ClientSize.Width - purchase_status.Width) / 2;
                    return;
                }

                Purchase p = new Purchase
                {
                    UserId = currentUser.UserId,
                    ItemId = item.ItemId,
                    Quantity = quantity,
                    TotalPrice = total,
                    DatePurchased = DateTime.Now
                };

                db.Purchases.InsertOnSubmit(p);
                user.Balance += total;
                db.SubmitChanges();

                purchase_status.ForeColor = Color.Green;
                purchase_status.Text = $"Purchased {quantity} x {selectedItem.Name} for ${total:F2}";
                purchase_status.Left = (this.ClientSize.Width - purchase_status.Width) / 2;
            }
        }
    }
}
