using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            FrmReports reports = new FrmReports();
            Close();
            reports.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            Close();
            settings.Show();
        }

        private void BtnLock_Click(object sender, EventArgs e)
        {
            FrmLock @lock = new FrmLock();
            Close();
            @lock.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers customers = new FrmCustomers();
            Close();
            customers.Show();
        }

        private void BtnTableOrder_Click(object sender, EventArgs e)
        {
            FrmTables tables = new FrmTables();
            Close();
            tables.Show();
        }

        private void BtnRezervation_Click(object sender, EventArgs e)
        {
            FrmRezervation rezervation = new FrmRezervation();
            Close();
            rezervation.Show();
        }

        private void BtnPackageService_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            Close();
            packageService.Show();
        }

        private void BtnSafeTransactions_Click(object sender, EventArgs e)
        {
            FrmSafeTransactions safeTransactions = new FrmSafeTransactions();
            Close();
            safeTransactions.Show();
        }

        private void BtnKitchen_Click(object sender, EventArgs e)
        {
            FrmKitchen kitchen = new FrmKitchen();
            Close();
            kitchen.Show();
        }
    }
}
