namespace labb.Models
{
      public class UserData
    {
        public List<User> GetUsers()
        {
            var users = new List<User>
        {
           new User(
            id: 1,
            name: "Leo Andersson",
            email: "Leo.Andersson@example.com",
            address: new Address { Street = "Birger jarls gatan", City = "Springfield", ZipCode = "12345" },
            company: new Company { Name = "TechCorp", CatchPhrase = "Innovating the future" }
            ),

           new User( 
               id : 2, 
               name : "Rigmor Carlson", 
               email : "rigmor.carlson@mailmetrash.com",
               address : new Address { Street = "Nyvägen", City = "Malmö", ZipCode = "372 37" },
               company : new Company { Name = "BizInc", CatchPhrase = "Business solutions for all" } 
                ),

            new User(
                id : 1, 
                name : "Elinor Brandt", 
                email : "Elinor.Brandt@example.com",
                address : new Address { Street = "Han river St", City = "Stockholm", ZipCode = "17345" },
                company : new Company { Name = "Hybe", CatchPhrase = "In music we belive" } 
                ),

            new User ( 
                id : 2, 
                name : "Pontus Svärd", 
                email : "pontus.svard@example.com",
                address : new Address { Street = "Rotholmsviken", City = "Göteborg", ZipCode = "41721" },
                company : new Company { Name = "PonInc", CatchPhrase = "Pontus AB" }     
                ),

           new User ( 
                id : 1, 
                name : "Sara Lager",
                email : "sara.lager@example.com",
                address : new Address { Street = "Kvarnbäcken", City = "Karlshamn", ZipCode = "18345" },
                company : new Company { Name = "SaraCorp", CatchPhrase = "Trust us" } 
                ),

            new User (
                id : 2, 
                name : "Elma Pålsson",
                email : "elma.pålsson@example.com",
                address : new Address { Street = "Byn västtomten", City = "Uppsala", ZipCode = "54321" },
                company : new Company { Name = "ElmaInc", CatchPhrase = "We make good quality clothes" } 
                ),

            new User ( 
                id : 1, 
                name : "Carolina Byström", 
                email : "Carolina.bystrom@example.com",
                address : new Address { Street = "Husholmsvägen", City = "Lund", ZipCode = "12444" },
                company : new Company { Name = "Carol AB", CatchPhrase = "Business for everybody" }           
                ),

            new User ( 
                id : 2, 
                name : "Frankie Franco", 
                email : "frankie@example.com",
                address : new Address { Street = "Frankly street", City = "San francisco", ZipCode = "12345" },
                company: new Company { Name = "FrankieCorp", CatchPhrase = "We make difference" }               
                ),

            new User ( 
                id : 1, 
                name : "Madeleine André", 
                email : "madeleine.andre@example.com",
                address : new Address { Street = "Gårdsvägen", City =  "Abisko", ZipCode = "15645" },
                company : new Company { Name = "Aurora", CatchPhrase = "Auroras light" } 
                ),

            new User(
                id : 2, 
                name : "Catharina Nyberg", 
                email : "catharina.nyberg@example.com",
                address : new Address { Street = "Vasagatan", City = "Stockholm", ZipCode = "45321" },
                company : new Company { Name = "NyBergInc", CatchPhrase = "New ideas" } 
                ),

        };

            return users.OrderBy(_ => Guid.NewGuid()).ToList(); 
        }
    }
}
