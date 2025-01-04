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

        public void setQuery(string consulta)
        {
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = consulta;
        }
        public void executeQuery()
        {
            Command.Connection = Connection;
            try
            {
                Connection.Open();
                SqlDataReader = Command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setParameter(string nombre, object valor)
        {
            Command.Parameters.AddWithValue(nombre, valor);
        }
        public void executeNonQuery()
        {
            Command.Connection = Connection;
            try
            {
                Connection.Open();
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
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
