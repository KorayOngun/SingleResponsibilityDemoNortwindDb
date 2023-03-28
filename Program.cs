using System.Data.SqlClient;
using SingleResponsibility.Manager.concrete;
using SingleResponsibilityDemoSql.Entity.Concrete;

namespace SingleResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;   
            ProductManager productManager = new ProductManager();

            productManager.Add(new Product
            {
                ProductName = "test deneme 0702 28032023",
                UnitPrice = 165,
                UnitsInStock = 42
            });


            var products = productManager.Get();



            Console.WriteLine("Products");
            foreach (var product in products)
            {
                Console.WriteLine($" name = {product.ProductName}\n\r price = {product.UnitPrice} \n\r stock = {product.UnitsInStock}");
                Console.WriteLine("--------------------------------------------------------------");
            }


            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Categories");
            Console.WriteLine("-------------------------------------------------------------------------------------------");


            CategoryManager categoryManager = new CategoryManager();
            var categories = categoryManager.Get();
            //foreach (var item in categories)
            //{
            //    Console.WriteLine($" id = {item.CategoryID}\n\r name = {item.CategoryName} \n\r Description = {item.Description}");
            //    Console.WriteLine("--------------------------------------------------------------");
            //}


            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("orders");
            Console.WriteLine("-------------------------------------------------------------------------------------------");


            OrderManager orderManager = new OrderManager();
            var orders = orderManager.Get();
            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"order id = {item.OrderID}\n\r CustomerID = {item.CustomerID} \n\r EmployeeID = {item.EmployeeID}");
            //    Console.WriteLine("--------------------------------------------------------------");
            //}
            var totalResult = orders.Count() + categories.Count() + products.Count();
            Console.WriteLine(totalResult);
            Console.WriteLine(DateTime.Now - start);
        }
    }
}