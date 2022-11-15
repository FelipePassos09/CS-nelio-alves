using System;
using System.Text;
using System.Globalization;

namespace ExecInheritinhg.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=");
            output.AppendLine($"{Name} (used) -> $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})");
            output.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=");
            
            return output.ToString();
        }
    }
}