using System;

namespace Orders.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        
        public Client(){}

        public Client(string name, string email, DateTime birth_date)
        {
            Name = name;
            Email = email;
            BirthDate = birth_date;
        }

        public override string ToString()
        {
            return $"Client Name: {Name}\nClient Email: {Email}\nClient Birth: {BirthDate.ToString("dd/MM/yyyy")}";
        }
    }
}