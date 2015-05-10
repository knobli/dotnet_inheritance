using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablePerType
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new InheritanceMappingContext())
            {
                
                 Student student = new Student(){Name = "Max", Surname = "Frisch", Street = "Student Street", Place = "Place", StudentNumber = "12345"};
                 context.Persons.Add(student);
                 context.SaveChanges();

                 Teacher teacher = new Teacher() { Name = "Toni", Surname = "Brunner", Street = "Student Street", Place = "Place", AnnualWage = 1230};
                 context.Persons.Add(teacher);
                 context.SaveChanges();
                 

                IQueryable<Person> linqPersons = from p in context.Persons select p;
                List<Person> persons = linqPersons.ToList();
                foreach (Person person in persons)
                {
                    Console.WriteLine(person.ToString());
                }

                Console.ReadLine();
            }
        }
    }
}
