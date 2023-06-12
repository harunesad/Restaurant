using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;

namespace Restaurant
{
    internal class EmployeeMovements
    {
        General general = new General();
        #region Fields
        private int id;
        private int employeeId;
        private string proccess;
        private DateTime date;
        private bool state;
        #endregion
        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Proccess
        {
            get { return proccess; }
            set { proccess = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public bool State
        {
            get { return state; }
            set { state = value; }
        }
        #endregion
        
        public bool EmployeeActionSave(EmployeeMovements em)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(general.connString);
            SqlCommand cmd = new SqlCommand("Insert Into EmployeeMovements(EMPLOYEEID,PROCESS,DATE)Values(@employeeId,@proccess,@date)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@employeeId", SqlDbType.VarChar).Value = em.employeeId;
                cmd.Parameters.Add("@proccess", SqlDbType.VarChar).Value = em.proccess;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = em.date;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }

            return result;
        }
    }
}
