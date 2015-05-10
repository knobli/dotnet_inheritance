using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablePerHierarchy
{
    public class InheritanceMappingContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public InheritanceMappingContext()
            : base("name=DbTest.connStr")
        {
            
        }
    }
}
