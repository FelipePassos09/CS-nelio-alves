using System.Globalization;
using System.Text;

namespace ExecInheritinhg.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        //public Product (){}

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        
        public virtual string PriceTag()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=");
            output.AppendLine($"{Name} -> $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");
            output.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=");

            return output.ToString();

        }
    }
}