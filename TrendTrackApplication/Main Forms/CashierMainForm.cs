using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrendTrackApplication.Admin_User_Control;

namespace TrendTrackApplication
{
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
            ShowPanel(cashierOrder1);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
        }
        private void frmMain_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_cashier_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Logout();
            }
        }
        private void Logout()
        {

            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
        private void ShowPanel(UserControl panel)
        {
            //adminDashboard1.Visible = false;
            cashierOrder1.Visible = false;
            //adminTransactions1.Visible = false;
            adminCustomers1.Visible = false;
            panel.Visible = true;


        }

        private void btn_order_cashier_Click(object sender, EventArgs e)
        {
            ShowPanel(cashierOrder1);
        }

       /* private void btn_orders_cashier_Click(object sender, EventArgs e)
        {
            ShowPanel(adminTransactions1);
        }*/

        private void btn_customer_cashier_Click(object sender, EventArgs e)
        {
            ShowPanel(adminCustomers1);
        }

      /*  private void btn_dashboard_cashier_Click(object sender, EventArgs e)
        {
            ShowPanel(adminDashboard1);
        }*/
    }
}
