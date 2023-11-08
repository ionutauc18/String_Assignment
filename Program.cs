using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this line of code concatenates three strings
            string greetings = "Hello," + "instructors!" + " This is an assignment.";
            Console.WriteLine(greetings);

            // this line of code converts a string to uppercase 
            string warning = "Stop!";
            warning = warning.ToUpper();
            Console.WriteLine(warning);

            // this line of code is a StringBuilder 
            StringBuilder music = new StringBuilder();
            music.Append("Music is generally defined as the art of arranging sound to create some combination of form, harmony, melody, rhythm, or otherwise expressive content.\nDefinitions of music vary depending on culture,though it is an aspect of all human societies and a cultural universal.\n");
            Console.WriteLine(music);

            Console.ReadLine();
        }
    }
}
