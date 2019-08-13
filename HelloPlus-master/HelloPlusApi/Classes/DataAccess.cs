using System.Configuration;
using System.Data.SqlClient;


namespace HelloPlusApi
{
    public class DataAccess
    {
        private SqlConnection con;
     
        protected SqlConnection DbConnection
        {
            get
            {
                if (this.con == null)
                {
                    string constr = ConfigurationManager.ConnectionStrings["DbSQL"].ConnectionString;
                    this.con = new SqlConnection(constr);
                }

                return this.con;
            }
            set { this.con = value; }
        }

    }

}


