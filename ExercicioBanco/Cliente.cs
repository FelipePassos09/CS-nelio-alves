using System.Globalization;

namespace ExercicioBanco
{
    class Cliente
    {
        private string Name { get;  }
        private string NumeroConta { get; }
        private char _firstDep;
        public double Saldo { get; private set; }

        public Cliente(string name, string conta)
        {
            Name = name;
            NumeroConta = conta;
        }

        public Cliente(string name, string conta, double saldo) : this(name, conta)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}\nCliente: {Name}\nSaldo Atual: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void Deposito(double amount)
        {
            Saldo += amount;
        }

        public void Saque(double amount)
        {
            Saldo -= (amount + 5.00);
        }
    }
}