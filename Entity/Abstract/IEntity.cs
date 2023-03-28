using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityDemoSql.Entity.Abstract
{
    public interface IEntity
    {
        Dictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> obj = new Dictionary<string, object>();
            foreach (var prop in GetType().GetProperties())
            {
                obj.Add(prop.Name, prop.GetValue(this, null));
            }
            return obj;
        }
    }
}
