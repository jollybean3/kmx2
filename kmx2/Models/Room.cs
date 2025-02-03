namespace kmx2.Models
{
    public class Room
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Code { get; private set; }

        public Room(string name, string description, string code)
        {
            Name = name;
            Description = description;

            if (code == null || code.Length == 0)
                throw new ArgumentException("code is required");

            Code = code;
        }
    }
}
