using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllThingsSpursMain
{
    internal class Players : Person
    { 
        public string Position { get; set; }

        public Players(string firstName, string lastName, int age, string club, string nation, string position) : base(firstName, lastName, age, club, nation)
        {
            Position = position;
        }

        public string GetPlayerInfo() 
        {
            return "First name: " + FirstName + "\n" + "Last name: " + LastName + "\n" + "Age: " + Age + "\n" + "Club: " + Club + "\n" + "Nation: " + Nation + "\n" + "Position: " + Position + "\n";
        }

        public string GetPlayerInfoCSV()
        {
            return FirstName + "," + LastName + "," + Age + "," + Club + "," + Nation + "," + Position;
        }
    }
}