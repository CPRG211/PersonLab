using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    /// <summary>
    /// Represents Person
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 27, 2023</remarks>
    internal class Person
    {
        // Fields
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        // Properties
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age
        {
            get { return age; }
            set
            {
                // Ensure age is valid
                if (value >= 0 && value <= 122)
                {
                    age = value;
                }
            }
        }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        /// <summary>
        /// User-defined constructor for Person
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="favoriteColor"></param>
        /// <param name="isWorking"></param>
        public Person(int id, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
            FavoriteColor = favoriteColor;
            IsWorking = isWorking;
        }

        /// <summary>
        /// Generates string with current persons info
        /// </summary>
        /// <returns>Formatted string</returns>
        public string DisplayPersonInfo()
        {
            string formatted = "";

            formatted += "ID: " + id + "\n";
            formatted += "First name: " + firstName + "\n";
            formatted += "Last name: " + lastName + "\n";
            //formatted += "Age: " + age + "\n";
            formatted += "Favorite Color: " + favoriteColor + "\n";
            //formatted += "Is Working: " + isWorking + "\n";

            //formatted = string.Format("ID: {0}\nFirst name: {1}", id, firstName);

            //formatted = $"ID: {id}\n";

            return formatted;
        }

        /// <summary>
        /// Changes persons favorite color to White
        /// </summary>
        public void ChangeFavoriteColor()
        {
            favoriteColor = "White";
        }

        //public static void ChangeFavoriteColor(Person p)
        //{
        //    p.favoriteColor = "White";
        //}

        /// <summary>
        /// Gets current person age in 10 years
        /// </summary>
        /// <returns>Age in 10 years</returns>
        public int GetAgeInTenYears()
        {
            int ageInTenYears = age + 10;

            return ageInTenYears;
        }

        /// <summary>
        /// Gets Person as human readable string
        /// </summary>
        /// <returns>Formatted string</returns>
        public override string ToString()
        {
            string formatted = "";

            formatted += "ID\t\t" + id + "\n";
            formatted += "First name\t" + firstName + "\n";
            formatted += "Last name\t" + lastName + "\n" ;

            return formatted;
        }
    }
}
