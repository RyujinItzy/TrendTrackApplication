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
            //ShowPanel(adminDashboard2);
            customizeDesing();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
        }

        private void frmMain_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ShowPanel(UserControl panel)
        {

          /*  adminDashboard2.Visible = false;
            adminUsers2.Visible = false;
            adminCategories2.Visible = false;
            adminProducts2.Visible = false;
            adminCustomers2.Visible = false;
            adminActLogAuditTrail1.Visible = false;
            adminReport1.Visible = false;
            adminArchive1.Visible = false;

            panel.Visible = true;*/
        }
        private void customizeDesing()
        {
            panel_inventory_subMenu.Visible = false;
            panel_Monitor_subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panel_inventory_subMenu.Visible == true)
            {
                panel_inventory_subMenu.Visible = false;
            }
            if (panel_Monitor_subMenu.Visible == true)
            {
                panel_Monitor_subMenu.Visible = false;
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




        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Hide();
            }
        }



        private void btn_users_Click(object sender, EventArgs e)
        {

           // ShowPanel(adminUsers2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // ShowPanel(adminCategories2);
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // ShowPanel(adminReport1);

        }


        private void flpContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_products_Click(object sender, EventArgs e)
        {
          //  ShowPanel(adminProducts2);
            hideSubMenu();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
           // ShowPanel(adminCustomers2);
        }

        private void btn_auditActLog_Click(object sender, EventArgs e)
        {
          //  ShowPanel(adminActLogAuditTrail1);
            hideSubMenu();
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {
          //  ShowPanel(adminArchive1);
            hideSubMenu();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
          //  ShowPanel(adminDashboard2);
        }

        private void btn_inventory_dropdown_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_inventory_subMenu);
        }
        private void btn_actlogs_monitor_dropdown_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_Monitor_subMenu);
        }

    }
}
