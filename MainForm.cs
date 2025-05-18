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
    public partial class MainForm : Form
    {
        private User currentUser;
        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void lbl_quantity_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbl_Welcome.Text = $"Welcome, {currentUser.Username}";
            lbl_Welcome.Left = (this.ClientSize.Width - lbl_Welcome.Width) / 2;

        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            var pf = new PurchaseForm(currentUser);
            pf.ShowDialog();
        }

        private void btn_viewBalance_Click(object sender, EventArgs e)
        {
            var bf = new BalanceForm(currentUser);
            bf.ShowDialog();
        }

        private void btn_viewPurchases_Click(object sender, EventArgs e)
        {
            var history = new HistoryForm(currentUser);
            history.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            this.Close();
            loginForm.ShowDialog();
        }
    }
}
