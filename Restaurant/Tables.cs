using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Tables
    {
        General general = new General();
        #region Fields
        private int id;
        private int capasity;
        private int serviceTour;
        private int state;
        private bool approval;
        #endregion
        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Capasity
        {
            get { return capasity; }
            set { capasity = value; }
        }

        public int ServiceTour
        {
            get { return serviceTour; }
            set { serviceTour = value; }
        }

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public bool Approval
        {
            get { return approval; }
            set { approval = value; }
        }
        #endregion
        public string SessionSum(int stateS)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(general.connString);
            SqlCommand cmd = new SqlCommand("Select DATE,TABLEID From Bills Right Join Tables on Bills.TABLEID = Tables.ID Where Tables.STATE=@state and Bills.State=0", con);
            SqlDataReader reader = null;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dt = Convert.ToDateTime(reader["DATE"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                reader.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
    }
}
