using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Data.Abstract
{
    public interface IDataAccess
    {
        int AddItem(string command, Dictionary<string, object> param);
        IEnumerable<SqlDataReader> GetItems(string command); 
    }
}
