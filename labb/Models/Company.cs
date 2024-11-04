using System.IO;
using System.Reflection.Emit;

namespace labb.Models
{
    public class Company
    {
        public string? Name { get; set; }
        public string? CatchPhrase { get; set; }

        public Company() { }

        public Company(string name, string catchPhrase)
        {
          Name = name;
          CatchPhrase = catchPhrase;
        }
    }
}
