namespace DictVotation.Entities
{
    public class Candidate
    {
        public string Name { get; set; }
        public int QntVotes { get; set; }
        
        public Candidate(){}

        public Candidate(string name, int qnt_votes)
        {
            Name = name;
            QntVotes = qnt_votes;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Candidate))
            {
                return false;
            }
            Candidate other = obj as Candidate;
            return Name.Equals(other.Name);
        }
    }
}