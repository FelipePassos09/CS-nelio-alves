namespace EmployeCad.Entities
{
    public class OutsourceEmployee : Employee
    {
        public double AdditionaCharge { get; set; }
        
        public  OutsourceEmployee (){}

        public OutsourceEmployee(string name, int hour, double valuePerHour, double additionaCharge)
            : base(name, hour, valuePerHour)
        {
            AdditionaCharge = additionaCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdditionaCharge * 1.1;
        }
    }
}