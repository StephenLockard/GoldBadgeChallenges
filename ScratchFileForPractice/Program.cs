using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchFileForPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testNumbers = new List<int>();
            Random number = new Random();
            int count = 0;
            do
            {
                testNumbers.Add(number.Next(0, 100000));
                count += 1;
            } while (count < 20);


            Console.WriteLine("Unsorted Random Numbers List");
            foreach (var result in testNumbers)
            {
                Console.WriteLine(result);
            }
                Console.ReadKey();

            testNumbers.Sort((a, b) => (a.ToString()[0].CompareTo(b.ToString()[0]))); // sort by first digit

            Console.WriteLine("First Digit Sorting");
            foreach (var result in testNumbers)
            {
                Console.WriteLine(result);
            }
                Console.ReadKey();
        }
    }
}
