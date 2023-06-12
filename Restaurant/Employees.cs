using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    internal class Employees
    {
        General general = new General();
        #region Fields
        private int id;
        private int missionId;
        private string name;
        private string surname;
        private string password;
        private string userName;
        private bool state;
        #endregion
        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int MissionId
        {
            get { return missionId; }
            set { missionId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public bool State
        {
            get { return state; }
            set { state = value; }
        }
        #endregion
        public bool EmployeeEntryControl(string password, int userId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(general.connString);
            SqlCommand cmd = new SqlCommand("Select * from Employees where ID=@Id and PASSWORD=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = userId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
        public void EmployeeGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();

            SqlConnection con = new SqlConnection(general.connString);
            SqlCommand cmd = new SqlCommand("Select * from Employees", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Employees employees = new Employees();
                employees.id = Convert.ToInt32(reader["ID"]);
                employees.missionId = Convert.ToInt32(reader["MISSIONID"]);
                employees.name = Convert.ToString(reader["NAME"]);
                employees.surname = Convert.ToString(reader["SURNAME"]);
                employees.password = Convert.ToString(reader["PASSWORD"]);
                employees.userName = Convert.ToString(reader["USERNAME"]);
                employees.state = Convert.ToBoolean(reader["State"]);
                cb.Items.Add(employees);
            }
            reader.Close();
            con.Close();
        }
        public override string ToString()
        {
            return name + " " + surname;
        }
    }
}
