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
    public partial class HistoryForm : Form
    {
        private User currentUser;
        public HistoryForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            lst_PurchaseHistory.Columns.Clear();
            lst_PurchaseHistory.Columns.Add("Date Purchased", 100);
            lst_PurchaseHistory.Columns.Add("Item", 150);
            lst_PurchaseHistory.Columns.Add("Quantity", 50);
            lst_PurchaseHistory.Columns.Add("Total Price", 100);

            using (var db = new StoreDBDataContext())
            {
                var purchases = db.Purchases
                    .Where(p => p.UserId == currentUser.UserId)
                    .OrderByDescending(p => p.DatePurchased)
                    .ToList();

                lst_PurchaseHistory.Items.Clear();

                foreach (var p in purchases)
                {
                    var row = new ListViewItem(p.DatePurchased.ToShortDateString());
                    row.SubItems.Add(p.Item.Name);
                    row.SubItems.Add(p.Quantity.ToString());
                    row.SubItems.Add($"${p.TotalPrice:F2}");
                    lst_PurchaseHistory.Items.Add(row);
                }
                
                if (purchases.Any())
                {
                    dtp_FromDate.Value = purchases.Min(p => p.DatePurchased);
                    dtp_ToDate.Value = purchases.Max(p => p.DatePurchased);
                }
                else
                {
                    dtp_FromDate.Value = DateTime.Today.AddMonths(-1);
                    dtp_ToDate.Value = DateTime.Today;
                }
                
            }
        }

        private void lst_PurchaseHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ApplyFilters_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtp_FromDate.Value.Date;
            DateTime toDate = dtp_ToDate.Value.Date.AddDays(1).AddSeconds(-1); // inclusive

            decimal minPrice = num_MinPrice.Value;
            decimal maxPrice = num_MaxPrice.Value;

            bool filterMin = minPrice > num_MinPrice.Minimum;
            bool filterMax = maxPrice < num_MaxPrice.Maximum;

            using (var db = new StoreDBDataContext())
            {
                var query = db.Purchases
                    .Where(p => p.UserId == currentUser.UserId
                             && p.DatePurchased >= fromDate
                             && p.DatePurchased <= toDate);

                if (filterMin)
                    query = query.Where(p => p.TotalPrice >= minPrice);

                if (filterMax)
                    query = query.Where(p => p.TotalPrice <= maxPrice);

                var results = query
                    .OrderByDescending(p => p.DatePurchased)
                    .Select(p => new
                    {
                        p.DatePurchased,
                        p.Quantity,
                        p.TotalPrice,
                        ItemName = p.Item.Name
                    })
                    .ToList();

                lst_PurchaseHistory.Items.Clear();

                foreach (var p in results)
                {
                    var row = new ListViewItem(p.DatePurchased.ToShortDateString());
                    row.SubItems.Add(p.ItemName);
                    row.SubItems.Add(p.Quantity.ToString());
                    row.SubItems.Add($"${p.TotalPrice:F2}");
                    lst_PurchaseHistory.Items.Add(row);
                }
            }
        }

        private void btn_ClearFilters_Click(object sender, EventArgs e)
        {
            dtp_FromDate.Value = DateTime.Today.AddMonths(-1);
            dtp_ToDate.Value = DateTime.Today;
            num_MinPrice.Value = num_MinPrice.Minimum;
            num_MaxPrice.Value = num_MaxPrice.Maximum;
            btn_ApplyFilters.PerformClick();
        }
    }
}
