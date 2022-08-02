using System.Globalization;
using System.Security.Principal;

namespace ExerciciosPropostos;

public class Produto
{
   /*Without constructors:
    public string Name;
    
    public int Quant;
    public double Price;*/

   private string _name;
   private int _quant;
   private double _price;
   public int Quant { get; private set; }
   public double Price { get; private set; }
   public Produto(string name, double price, int quant)
   {
       _name = name;
       _price = price;
       _quant = quant;
   }

   public Produto(string name, double price)
   {
       _name = name;
       _price = price;
   }

    public double TotalStockedValue()
    {
        return _price * _quant;
    }

    public void AddProducts(int quantidade)
    {
        _quant += quantidade;
    }

    public void RemoveProducts(int quantidade)
    {
        _quant -= quantidade;
    }

    /*public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        if (name != null && name.Length >= 3)
        {
            _name = name;
        }
    }*/

    public string Name
    {
        get { return _name; }
        set {if (value != null && value.Length >= 3)
        {
            _name = value;
        }}
    }

    /*public int Quant
    {
        get { return _quant; }
    }
    public double Price
    {
        get { return _price; }
    }*/
    public override string ToString()
    {
        return $"Produto: {_name}\nPreço: {_price.ToString("F2", CultureInfo.InvariantCulture)}\nQuantidade: {_quant}\n";
    }
}