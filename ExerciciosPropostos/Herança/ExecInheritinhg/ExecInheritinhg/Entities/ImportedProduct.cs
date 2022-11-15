using System.Text;
using System.Globalization;

namespace ExecInheritinhg.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=");
            output.AppendLine($"{Name} -> $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs Fee: {CustomFee.ToString("F2", CultureInfo.InvariantCulture)})");
            output.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=");

            return output.ToString();
        }
    }
}