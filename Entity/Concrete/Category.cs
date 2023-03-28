﻿using SingleResponsibilityDemoSql.Entity.Abstract;

namespace SingleResponsibilityDemoSql.Entity.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
