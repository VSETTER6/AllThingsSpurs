using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllThingsSpursMain
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Club { get; set; }
        public string Nation { get; set; }

        public Person(string firstName, string lastName, int age, string club, string nation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Club = club;
            Nation = nation;
        }
    }
}
