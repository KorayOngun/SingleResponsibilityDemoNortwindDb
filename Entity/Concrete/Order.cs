using SingleResponsibilityDemoSql.Entity.Abstract;

namespace SingleResponsibilityDemoSql.Entity.Concrete
{
    public class Order : IEntity
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
    }
}
