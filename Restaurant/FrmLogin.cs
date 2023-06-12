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
    public partial class FrmLogin : Form
    {
        General general = new General();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employees employees = (Employees)CbUser.SelectedItem;
            General.employeeId = employees.Id;
            General.employeeMissionId = employees.MissionId;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            bool result = employees.EmployeeEntryControl(TxtPassword.Text, General.employeeId);

            if (result)
            {
                EmployeeMovements em = new EmployeeMovements();
                em.EmployeeId = General.employeeId;
                em.Proccess = "Giriş Yaptı";
                em.Date = DateTime.Now;
                em.EmployeeActionSave(em);

                Hide();
                FrmMenu menu = new FrmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Şifreniz Yanlış?", "Uyarı !!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.EmployeeGetbyInformation(CbUser);
        }
    }
}
