// LINQ query for JOINS. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    class Person
    {
       public string Name{ get; set; }
       public string City { get; set; }
    }

    class City
    {
        public string Code { get; set; }
        public string FullName { get; set; }
    }
    class JoinsLINQ
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { Name = "Ram", City = "Skt"},
                new Person { Name = "Shyam", City = "Ktm"},
                new Person { Name = "Hari", City = "Pkr"},
            };

            List<City> cities = new List<City>()
            {
                new City { Code = "Skt", FullName = "Surkhet"},
                new City { Code = "Ktm", FullName = "Kathmandu"},
                new City { Code = "Pkr", FullName= "Pokhara"}
            };

            // joining people with cities based on City code 
            var result = people.Join(cities, 
                person => person.City, 
                city => city.Code, 
                (person, city) => new
                {
                    PersonName = person.Name, 
                    CityName = city.FullName
                }
            );
            foreach (var item in result)
            {
                Console.WriteLine($"{item.PersonName} lives in {item.CityName}");
            }
        }
    }
}
