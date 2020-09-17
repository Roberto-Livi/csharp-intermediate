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

            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                System.Console.WriteLine(number);
            }
            else
            {
                System.Console.WriteLine("Conversion failed");
            }

        }

        static void useParams()
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1, 2));
            System.Console.WriteLine(calculator.Add(1, 2, 3));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occured");
            }
        }
        }
    }

