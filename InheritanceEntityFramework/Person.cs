using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablePerHierarchy
{
    public abstract class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string Place { get; set; }

        public override string ToString(){ return Name + " " + Surname; }
    }

    public class Student : Person
    {
        public String StudentNumber { get; set; }

        public override string ToString() { return base.ToString() + ": Student"; }
    }

    public class Teacher : Person
    {
        public int AnnualWage { get; set; }

        public override string ToString(){ return base.ToString() + ": Teacher"; }
    }
}
