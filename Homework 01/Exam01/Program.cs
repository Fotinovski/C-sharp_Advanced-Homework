using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<string> names = new List<string>();



            while (true)
            {
                Console.WriteLine("Enter your name or press 'x' to exit.");
                string input = Console.ReadLine();
                if (input != "x")
                {
                    names.Add(input);

                }
                else break;

            }

            Console.WriteLine("Enter text here:");
            string inputText = Console.ReadLine();

            List<string> trimmedInputList = inputText.Split(" ").ToList();

            foreach (string name in names)
            {

                var count = trimmedInputList.Where(name1 => name1.ToLower().Contains(name.ToLower()));

                Console.WriteLine($"{name} appears {count.Count()} times ");


            }

              
            
        }
    }
}
