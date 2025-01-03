using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class DataBase
    {
        private SqlConnection Connection;
        private SqlCommand Command;
        private SqlDataReader SqlDataReader;

        public DataBase() { 
            Connection = new SqlConnection("server=.\\SQLEXPRESS; database=PROMOS_DB; integrated security=true");
            Command = new SqlCommand();
        }

        public SqlDataReader reader { get { return SqlDataReader; } }

        public void Consulta(string consulta)
        {
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = consulta;
            Command.Connection = Connection;

            try
            {
                Connection.Open();
                SqlDataReader = Command.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CloseConecction()
        {
            if (SqlDataReader != null)
                SqlDataReader.Close();
            Connection.Close();
        }
    }
}
