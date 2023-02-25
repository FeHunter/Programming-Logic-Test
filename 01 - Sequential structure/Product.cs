using System.Globalization;

namespace Course
{
    class Product
    {
        public int CodeBar {get; set;}
        public int Quantity {get; set;}
        public double Price {get; set;}

        public Product(int code, int quantity, double price)
        {
            CodeBar = code; Quantity = quantity; Price = price;
        }

        public double TotalPrice ()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return "Code ["+CodeBar+"] "
            + "Total Price: " 
            + TotalPrice().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}