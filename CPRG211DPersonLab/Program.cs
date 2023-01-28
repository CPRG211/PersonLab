using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    /// <summary>
    /// CPRG211: Lab 1 (Classes and Objects)
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 27, 2023</remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Person objects
            Person person1 = new Person(1, "Ian", "Brooks", 30, "Red", true);
            Person person2 = new Person(2, "Gina", "Smith", 18, "Red", false);
            Person person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Person person4 = new Person(4, "Mary", "Beeals", 28, "Yellow", true);

            // Display Gina's information
            string ginasInfo = person2.DisplayPersonInfo();
            Console.WriteLine(ginasInfo);

            // Display Mike's information
            string mikesInfo = person3.ToString();
            Console.WriteLine(mikesInfo);

            // Change Ian's favorite color to white
            person1.ChangeFavoriteColor();
            //Person.ChangeFavoriteColor(person1);

            // Display Mary's age in 10 years
            int marysAgeTenYears = person4.GetAgeInTenYears();
            Console.WriteLine("Mary's age in 10 years: " + marysAgeTenYears);

            // Create Relation instances (linking Person instances together)
            Relation relation1 = new Relation("Sister", person2, "Sister", person4);
            Relation relation2 = new Relation("Brother", person1, "Brother", person3);

            // Display first relation
            Console.WriteLine(relation1.ToString());

            // Create and populate list of people
            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            // Determine average age
            int sum = 0;

            // Get sum of everyone's age
            foreach (Person person in people)
            {
                sum += person.Age;
            }

            // Divide sum by number of people.
            // One operand for / operator must be double for result to be double.
            double average = sum / (double) people.Count;

            // Display average age
            Console.WriteLine("Average age: " + average);
        }
    }
}
