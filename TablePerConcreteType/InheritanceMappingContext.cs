using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablePerConcreteType
{
    public class InheritanceMappingContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public InheritanceMappingContext() : base("name=DbTest.connStr")
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Student");
            });
            modelBuilder.Entity<Teacher>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Teacher");
            });
        }
    }
}
