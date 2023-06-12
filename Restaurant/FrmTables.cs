using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FrmTables : Form
    {
        General general = new General();
        public FrmTables()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            Close();
            menu.Show();
        }

        private void BtnTable1_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable1.Text.Length;

            General.buttonValue = BtnTable1.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable1.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable2_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable2.Text.Length;

            General.buttonValue = BtnTable2.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable2.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable3_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable3.Text.Length;

            General.buttonValue = BtnTable3.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable3.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable4_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable4.Text.Length;

            General.buttonValue = BtnTable4.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable4.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable5_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable5.Text.Length;

            General.buttonValue = BtnTable5.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable5.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable6_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable6.Text.Length;

            General.buttonValue = BtnTable6.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable6.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable7_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable7.Text.Length;

            General.buttonValue = BtnTable7.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable7.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable8_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable8.Text.Length;

            General.buttonValue = BtnTable8.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable8.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable9_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable9.Text.Length;

            General.buttonValue = BtnTable9.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable9.Name;
            Close();
            packageService.ShowDialog();
        }

        private void BtnTable10_Click(object sender, EventArgs e)
        {
            FrmPackageService packageService = new FrmPackageService();
            int length = BtnTable10.Text.Length;

            General.buttonValue = BtnTable10.Text.Substring(length - 7, 7);
            General.buttonName = BtnTable10.Name;
            Close();
            packageService.ShowDialog();
        }

        private void FrmTables_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(general.connString);
            SqlCommand cmd = new SqlCommand("SELECT STATE,ID FROM Tables", con);
            SqlDataReader reader = null;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Name == "BtnTable" + reader["ID"].ToString() && reader["STATE"].ToString() == "1")
                        {
                            item.BackgroundImage = (Image)(Properties.Resources.S);
                        }
                        else if (item.Name == "BtnTable" + reader["ID"].ToString() && reader["STATE"].ToString() == "2")
                        {
                            Tables tables = new Tables();
                            DateTime dt1 = Convert.ToDateTime(tables.SessionSum(2));
                            DateTime dt2 = DateTime.Now;

                            string st1 = Convert.ToDateTime(tables.SessionSum(2)).ToShortTimeString();
                            string st2 = DateTime.Now.ToShortTimeString();

                            DateTime t1 = dt1.AddMinutes(DateTime.Parse(st1).TimeOfDay.TotalMinutes);
                            DateTime t2 = dt2.AddMinutes(DateTime.Parse(st2).TimeOfDay.TotalMinutes);

                            var fark = t2 - t1;
                        }
                    }
                }
            }
        }
    }
}
