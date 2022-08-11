namespace ExerciciosPropostos;

public class Stock
{
    private string Item { get; }
    private int _quantidade;
    private double _valor;
    private string Setor { get; }
    private string Id { get; }
    private string Marca { get; }

    public Stock()
    {
        
    }
    
    public int Quantidade
    {
        get { return _quantidade; }
        set
        {
            if (value != 0)
            {
                _quantidade = value;
            }
        }
    }

    public double Valor
    {
        get { return _valor; }
        set
        {
            if (value != 0.00)
            {
                _valor = value;
            }
        }
    }
    
    
}