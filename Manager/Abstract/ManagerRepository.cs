using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibility.Data.Concrete;
using SingleResponsibilityDemoSql.Entity.Abstract;

namespace SingleResponsibility.Manager.@abstract
{
    public abstract class ManagerRepository<T> where T : class ,IEntity, new()
    {
        private string _commandAdd;
        private string _commandGet;
        Type type = typeof(T);
        DataAccess data;
        
        public ManagerRepository(string commandAdd, string commandGet)
        {
            data = new DataAccess();
            _commandAdd = commandAdd;
            _commandGet = commandGet;
        }

        public int Add(T entity)
        {
            return data.AddItem(_commandAdd, entity.ToDictionary());
        }

        public List<T> Get()
        {
            List<T> list = new List<T>();
            foreach (var item in data.GetItems(_commandGet))
            {
                list.Add(CreateObject(item));
            }
            return list;
        }

        private T CreateObject(SqlDataReader item)
        {
            T obj = (T)Activator.CreateInstance(type);
            foreach (var prop in type.GetProperties())
            {
                prop.SetValue(obj, item[prop.Name]);
            }
            return obj;
        }
    }
}
