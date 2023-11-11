namespace MyClassLibrary
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public int? PostNumber { get; set; }
        public string? City { get; set; }
        public bool? IsVIP { get; set; }

        public Customer(int id, string name, string email)
        {
            CustomerId = id;
            Name = name;
            Email = email;
        }
    }
}