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
    public partial class BalanceForm : Form
    {
        private User currentUser;
        public BalanceForm(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            using (var db = new StoreDBDataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == currentUser.UserId);
                if (user != null)
                {
                    lbl_Balance.Text = $"${user.Balance.ToString("F2")}";
                    lbl_Balance.Left = (this.ClientSize.Width - lbl_Balance.Width) / 2;
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            decimal paymentAmount = payment_amt.Value;
            if (paymentAmount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.");
                return;
            }

            using (var db = new StoreDBDataContext())
            {
                var user = db.Users.FirstOrDefault(u => u.UserId == currentUser.UserId);
                if (user != null)
                {
                    // add new payment  
                    Payment payment = new Payment
                    {
                        UserId = user.UserId,
                        AmountPaid = paymentAmount,
                        DatePaid = DateTime.Now
                    };
                    db.Payments.InsertOnSubmit(payment);

                    user.Balance -= paymentAmount;
                    db.SubmitChanges();

                    lbl_BalanceStatus.ForeColor = Color.Green;
                    lbl_BalanceStatus.Text = $"Payment of ${payment.AmountPaid:F2} applied. New balance: ${user.Balance:F2}";
                    payment_amt.Value = 0;
                    lbl_Balance.Text = $"${user.Balance.ToString("F2")}";
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
