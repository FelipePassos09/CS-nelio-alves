namespace Students.Entities
{
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        
        public Student (){}

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return Id.Equals(other.Id);
        }
    }
}