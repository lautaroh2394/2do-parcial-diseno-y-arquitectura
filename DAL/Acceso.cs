using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class Acceso
    {
        static string CONNECTION_STRING = "Server=WINDOWS-J8OE48L\\SQLEXPRESS;Database=cursos;Trusted_Connection=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(Acceso.CONNECTION_STRING);
        }

        public int ExecuteProcedure(string command, SqlParameter[] parameters = null)
        {
            SqlConnection connection = this.GetConnection();
            int r = 0;
            try
            {
                connection.Open();
                SqlCommand c = new SqlCommand(command, connection);
                c.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                    foreach (SqlParameter sqlParameter in parameters)
                    {
                        c.Parameters.AddWithValue(sqlParameter.ParameterName, sqlParameter.Value);
                    }
                r = c.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                if (connection.State != ConnectionState.Closed) connection.Close();
                Console.WriteLine("Error al ejecutar procedimiento " + command, e.ToString());
            }
            return r;
        }

        public DataSet GetDataSourceForCommand(string command, SqlParameter[] parameters = null)
        {
            SqlConnection connection = this.GetConnection();
            SqlCommand c = new SqlCommand(command, connection);
            if (parameters != null) c.Parameters.AddRange(parameters);
            DataSet ds = new DataSet();
            try {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(c);
                adapter.Fill(ds);
                connection.Close();
            }
            catch (Exception e) {
                if (connection.State != ConnectionState.Closed) connection.Close();
                Console.WriteLine("Error al obtener data source para el comando: " + command, e.ToString()); 
            }

            return ds;
        }

        public DataSet GetDataSourceForProcedure(string command, SqlParameter[] parameters = null)
        {
            SqlConnection connection = this.GetConnection();
            SqlCommand c = new SqlCommand(command, connection);
            c.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(c);
                adapter.Fill(ds);
                connection.Close();
            }
            catch (Exception e)
            {
                if (connection.State != ConnectionState.Closed) connection.Close();
                Console.WriteLine("Error al obtener data source para el procedure: " + command, e.ToString());
            }
            return ds;
        }
    }
}
