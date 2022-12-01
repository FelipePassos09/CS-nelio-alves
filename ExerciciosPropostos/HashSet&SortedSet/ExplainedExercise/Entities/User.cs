using System;

namespace ExplainedExercise.Entities
{
    public class User
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        
        public User(){}

        public User(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is User))
            {
                return false;
            }

            User other = obj as User; 
            return Name.Equals(other.Name);
        }
    }
}