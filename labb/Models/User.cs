using System.Xml.Linq;

namespace labb.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Address Address { get; set; } = new Address();
        public Company Company { get; set; } = new Company();

        public User() { }

        public User(int id, string name, string email, Address address, Company company)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;
            Company = company;
        }
    }
}
