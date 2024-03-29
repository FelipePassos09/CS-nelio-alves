using System.Runtime.InteropServices;

namespace Orders.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
            
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Product Name: {Name}\nProduct Price: {Price}";
        }
    }
}