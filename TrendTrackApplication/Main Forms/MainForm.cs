using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrendTrackApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowPanel(adminDashboard2);
            customizeDesing();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
        }

        private void frmMain_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ShowPanel(UserControl panel)
        {

            adminDashboard2.Visible = false;
            adminUsers1.Visible = false;
            adminCategories1.Visible = false;
            adminProduct1.Visible = false;
            adminCustomers1.Visible = false;
            adminTransactions1.Visible = false;
            adminTransactions2.Visible = false;
            adminActivityLog1.Visible = false;
            //adminAuditTrail1.Visible = false;
            adminReport1.Visible = false;
            adminArchive1.Visible = false;

            panel.Visible = true;


        }
        private void customizeDesing()
        {
            panel_Monitor_subMenu.Visible = false;
            panel_sales_subMenu.Visible = false;
            panel_monitor.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_monitor.Visible == true)
            {
                panel_monitor.Visible = false;
            }
            if (panel_Monitor_subMenu.Visible == true)
            {
                panel_Monitor_subMenu.Visible = false;
            }
            if (panel_sales_subMenu.Visible == true)
            {
                panel_sales_subMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(adminDashboard2);
        }
        //drop down for inventory
        private void btn_admin_inventory_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Monitor_subMenu);
        }
        //drop down for sales
        private void btn_admin_sales_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_sales_subMenu);
        }
        //drop down for actmonitor
        private void btn_admin_actMonitor_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_monitor);
        }

        private void btn_admin_users_Click(object sender, EventArgs e)
        {
            ShowPanel(adminUsers1);
            ;
        }

        private void btn_admin_categories_Click(object sender, EventArgs e)
        {
            ShowPanel(adminCategories1);
        }

        private void btn_admin_products_Click(object sender, EventArgs e)
        {
            ShowPanel(adminProduct1);
        }

        private void btn_admin_order_Click(object sender, EventArgs e)
        {
            ShowPanel(adminTransactions1);
        }

        private void btn_admin_customers_Click(object sender, EventArgs e)
        {
            ShowPanel(adminCustomers1);
        }

        private void btn_admin_actLog_Click(object sender, EventArgs e)
        {
            ShowPanel(adminActivityLog1);
        }

      /* private void btn_admin_audit_Click(object sender, EventArgs e)
        {
            ShowPanel(adminAuditTrail1);
        }*/

        private void btn_admin_reports_Click(object sender, EventArgs e)
        {
            ShowPanel(adminReport1);
        }

        private void btn_admin_archive_Click(object sender, EventArgs e)
        {
            ShowPanel(adminArchive1);
        }

        private void btn_admin_logout_Click(object sender, EventArgs e)
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
    }
}
