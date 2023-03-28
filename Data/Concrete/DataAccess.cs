using SingleResponsibility.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Data.Concrete
{
    public class DataAccess : IDataAccess
    {
        SqlConnection sqlConnection;
        public DataAccess()
        {
            sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public int AddItem(string command, Dictionary<string, object> param)
        {
            sqlConnection.Open();
            SqlCommand cmd = createCommand(command, param);
            var result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }

        public IEnumerable<SqlDataReader> GetItems(string command)
        {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = createCommand(command).ExecuteReader();
            
            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    yield return sqlDataReader;
                }
            }
            yield break;
        }

        private SqlCommand createCommand(string command, Dictionary<string, object>? param = null)
        {
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = command;
            if (param != null) AddParams(cmd, param);
            return cmd;
        }
        private void AddParams(SqlCommand cmd, Dictionary<string, object> param)
        {
            foreach (var item in param)
                cmd.Parameters.AddWithValue(item.Key, item.Value);
        }
    }
}
