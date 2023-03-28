using SingleResponsibility.Manager.@abstract;
using SingleResponsibilityDemoSql.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Manager.concrete
{
    public class OrderManager : ManagerRepository<Order>
    {
        private static string commandGet = "SELECT OrderID, CustomerID, EmployeeID From Orders";
        public OrderManager():base("",commandGet)
        {
            
        }
    }
}
