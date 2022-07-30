using System.Globalization;

namespace ExerciciosPropostos;

public class Produto
{
   /*Without constructors:
    public string Name;
    
    public int Quant;
    public double Price;*/

   public string Name;
   public int Quant;
   public double Price;
   public Produto(string name, double price, int quant)
   {
       Name = name;
       Price = price;
       Quant = quant;
   }
   

    public double TotalStockedVAlue()
    {
        return Price * Quant;
    }

    public void AddProducts(int quantidade)
    {
        Quant += quantidade;
    }

    public void RemoveProducts(int quantidade)
    {
        Quant -= quantidade;
    }

    public override string ToString()
    {
        return $"Produto: {Name}\nPreço: {Price.ToString("F2", CultureInfo.InvariantCulture)}\nQuantidade: {Quant}\n";
    }
}