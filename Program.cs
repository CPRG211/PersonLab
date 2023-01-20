using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211DPersonLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1;
            Person person2 = new Person(2, "Gina", "Smith", 20, "Red", false);
            Person person3;
            Person person4;

            Console.WriteLine(person2.ToString());
        }
    }
}
