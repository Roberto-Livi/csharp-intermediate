using System;

namespace csharp_intermediate
{
    class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);

            // System.Console.WriteLine(customer.Id);
            // System.Console.WriteLine(customer.Name);

            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            System.Console.WriteLine("Point is at ({0} {1})", point.X, point.Y);
        }
    }
}
