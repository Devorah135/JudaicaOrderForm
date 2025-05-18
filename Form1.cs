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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = username_enter.Text;
            string password = password_enter.Text;

            using (var db = new StoreDBDataContext())
            {
                // get valid user
                var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
                if (user != null)
                {
                    message_label.ForeColor = Color.Green;
                    message_label.Text = "Login Successful!";
                    message_label.Visible = true;
                    message_label.Left = (this.ClientSize.Width - message_label.Width) / 2;


                    // delay
                    Timer timer = new Timer();
                    timer.Interval = 1000;
                    timer.Tick += (s, args) =>
                    {
                        timer.Stop();
                        MainForm main = new MainForm(user);
                        main.Show();
                        this.Hide();
                    };
                    timer.Start();
                }
                else
                {
                    message_label.ForeColor= Color.Red;
                    message_label.Text = "Invalid username or password.";
                    message_label.Left = (this.ClientSize.Width - message_label.Width) / 2;
                    password_enter.Clear();

                }
            }
        }
    }
}
