using SingleResponsibilityDemoSql.Entity.Abstract;

namespace SingleResponsibilityDemoSql.Entity.Concrete
{
    public class Product : IEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

    }
}
