using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06RealLifeExampleRecursion
{
    class Program
    {
        static int fileCounter = 0;

        static void Main(string[] args)
        {            
            Console.WriteLine("Please enter a filepath to find all files:");
            var path = Console.ReadLine();
            FindFiles(path);
            Console.WriteLine($"--- Total number of files: {fileCounter} ---");

            Console.ReadLine();
        }

        private static void FindFiles(string path)
        {
            foreach (var fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
                fileCounter++;
            }

            foreach (var directory in Directory.GetDirectories(path))
            {
                //Recursive call
                FindFiles(directory);
            }            
        }
    }
}
