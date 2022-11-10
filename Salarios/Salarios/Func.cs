using System.Collections.Generic;

namespace Salarios;

public class Func
{
    private int _id { get; }
    private double _salario { get; set; }
    private string Nome { get; set; }

    public Func(int id, double ammount, string name)
    {
        _id = id;
        _salario = ammount;
        Nome = name;
    }

    public void Aumento(double percent)
    {
        _salario += ((percent / 100) + percent);
    }
        
    public override string ToString()
    {
        return $"Id: {_id}\nFuncionário: {Nome}\nSalario: {_salario}";
    }
}