using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._03hw
{
    internal class Program
    {
        static void Main()
        {
            string input = "ahb acb aeb aeeb abcd axeb";
            string pattern = @"a\wb";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }  
    }
}
