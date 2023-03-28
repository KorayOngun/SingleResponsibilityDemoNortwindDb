using SingleResponsibility.Manager.@abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibility.Data.Concrete;
using SingleResponsibilityDemoSql.Entity.Concrete;
 

namespace SingleResponsibility.Manager.concrete
{
    public class ProductManager : ManagerRepository<Product>
    {

        private static string commandAdd = "INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES (@ProductName, @UnitPrice, @UnitsInStock)";
        private static string commandGet = "SELECT ProductName, UnitPrice, UnitsInStock From Products";
        public ProductManager() : base(commandAdd, commandGet) { }
    
    }
}
