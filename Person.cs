using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
            FavoriteColor = favoriteColor;
            IsWorking = isWorking;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "ID: " + id + "\n";
            formatted += "First name: " + firstName + "\n";
            formatted += "Last name: " + lastName + "\n" ;

            return formatted;
        }
    }
}
