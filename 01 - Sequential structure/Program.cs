using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course 
{
    class Program
    {
        static void Main ()
        {

            List<Product> products = new List<Product>();

            System.Console.Write("How many parts to check: ");
            int n = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            for (int i=0; i < n; i++)
            {
                System.Console.Write("Code: ");
                int code = int.Parse(Console.ReadLine());

                System.Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                System.Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                System.Console.WriteLine();

                products.Add (new Product(code, quantity, price));
            }

            foreach (Product p in products)
            {
                System.Console.WriteLine(p);
            }

            System.Console.WriteLine();
        }
    }
}