using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ReverseEachWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "one two three four five";

            var reversedString = string.Join(" ",  inputString
                .Split(' ')
                .Select(x => new String(x.Reverse().ToArray())));
            
            Console.WriteLine(reversedString);
            Console.ReadLine();
        }
    }
}
