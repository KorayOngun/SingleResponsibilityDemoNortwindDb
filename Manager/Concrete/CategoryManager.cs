using SingleResponsibility.Manager.@abstract;
using SingleResponsibilityDemoSql.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Manager.concrete
{
    public class CategoryManager : ManagerRepository<Category>
    {
        private static string commandGet = "SELECT CategoryID, CategoryName, Description From Categories";

        public CategoryManager():base("",commandGet)
        {
            
        }
    }
}
