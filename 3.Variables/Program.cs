using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variable
            string name;
            int age;

            //initialize variables
            name = "John";
            age = 10;

            Console.WriteLine("Hi "+ name);
            Console.WriteLine("You are "+ age + " years of age.");
            Console.WriteLine("Next year you will be " + (age + 1));

            age = 10 + 10;

            Console.WriteLine("In 10 years time you will be " + age);

            name = "Nokwanda";
            Console.WriteLine("Hello " + name);

            //Declare and iniyialise same time!
            string lastName = "Khubisa";

            Console.WriteLine("Your last name is " + lastName);

            //freeze console
            Console.ReadLine();
        }
    }
}
