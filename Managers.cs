using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllThingsSpursMain
{
    internal class Managers : Person
    {
        public string Philosophy { get; set; }

        public Managers(string firstName, string lastName, int age, string club, string nation, string philosophy) : base(firstName, lastName, age, club, nation)
        {
            Philosophy = philosophy;
        }

        public string GetManagersInfo()
        {
            return "First name: " + FirstName + "\n" + "Last name: " + LastName + "\n" + "Age: " + Age + "\n" + "Club: " + Club + "\n" + "Nation: " + Nation + "\n" + "Philosophy: " + Philosophy;
        }

        public string GetManagersInfoCSV()
        {
            return FirstName + "," + LastName + "," + Age + "," + Club + "," + Nation + "," + Philosophy;
        }
    }
}
