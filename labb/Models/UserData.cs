namespace labb.Models
{
      public class UserData
    {
        public List<User> GetUsers()
        {
            var users = new List<User>
        {
            new User { Id = 1, Name = "Leo Andersson", Email = "Leo.Andersson@example.com",
                Address = new Address { Street = "Birger jarls gatan", City = "Springfield", ZipCode = "12345" },
                Company = new Company { Name = "TechCorp", CatchPhrase = "Innovating the future" } },

            new User { Id = 2, Name = "Rigmor Carlson", Email = "rigmor.carlson@mailmetrash.com",
                Address = new Address { Street = "Nyvägen", City = "Malmö", ZipCode = "372 37" },
                Company = new Company { Name = "BizInc", CatchPhrase = "Business solutions for all" } },

            new User { Id = 1, Name = "Elinor Brandt", Email = "Elinor.Brandt@example.com",
                Address = new Address { Street = "Han river St", City = "Stockholm", ZipCode = "17345" },
                Company = new Company { Name = "Hybe", CatchPhrase = "In music we belive" } },

            new User { Id = 2, Name = "Pontus Svärd", Email = "pontus.svard@example.com",
                Address = new Address { Street = "Rotholmsviken", City = "Göteborg", ZipCode = "41721" },
                Company = new Company { Name = "PonInc", CatchPhrase = "Pontus AB" } },

           new User { Id = 1, Name = "Sara Lager", Email = "Benjamin.lager@example.com",
                Address = new Address { Street = "Kvarnbäcken", City = "Karlshamn", ZipCode = "18345" },
                Company = new Company { Name = "BenjiCorp", CatchPhrase = "Trust us" } },

            new User { Id = 2, Name = "Elma Pålsson", Email = "elma.pålsson@example.com",
                Address = new Address { Street = "Byn västtomten", City = "Uppsala", ZipCode = "54321" },
                Company = new Company { Name = "ElmaInc", CatchPhrase = "We make good quality clothes" } },

            new User { Id = 1, Name = "Carolina Byström", Email = "Carolina.bystrom@example.com",
                Address = new Address { Street = "Husholmsvägen", City = "Lund", ZipCode = "12444" },
                Company = new Company { Name = "Carol AB", CatchPhrase = "Business for everybody" } },

            new User { Id = 2, Name = "Frankie Franco", Email = "frankie@example.com",
                Address = new Address { Street = "Frankly street", City = "San francisco", ZipCode = "12345" },
                Company = new Company { Name = "FrankieCorp", CatchPhrase = "We make difference" } },

            new User { Id = 1, Name = "Madeleine André", Email = "madeleine.andre@example.com",
                Address = new Address { Street = "Gårdsvägen", City = "Abisko", ZipCode = "15645" },
                Company = new Company { Name = "Aurora", CatchPhrase = "Auroras light" } },

            new User { Id = 2, Name = "Catharina Nyberg", Email = "catharina.nyberg@example.com",
                Address = new Address { Street = "Vasagatan", City = "Stockholm", ZipCode = "45321" },
                Company = new Company { Name = "NyBergInc", CatchPhrase = "New ideas" } },

        };

            return users.OrderBy(_ => Guid.NewGuid()).ToList();
        }
    }
}
