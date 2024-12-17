namespace Domain.Entities
{
    public class Category
    {
        public static int _lastId = 0;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Category(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty");
            if (name.Length > 50)
                throw new ArgumentException("Name cannot be longer than 50 characters");
            Id = Interlocked.Increment(ref _lastId);
            Name = name;
        }
    }
}
