using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTrimCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // CASE 01
            string input = "    lalala    l";
            string output = LTrim(input);
            Console.WriteLine($"1st Result:    {output.Equals("lalala    l")}");

            // CASE 02
            input = "         xxx   xx          ";
            output = LTrim(input);
            Console.WriteLine($"2nd Result:    {output.Equals("xxx   xx          ")}");

            // CASE 03
            input = "     y_ y  xx  ";
            output = LTrim(input);
            Console.WriteLine($"3rd Result:    {output.Equals("y_ y  xx  ")}");

            // CASE 04
            input = "  xxx_xx  aa        ";
            output = LTrim(input);
            Console.WriteLine($"4rd Result:    {output.Equals("xxx_xx  aa        ")}");

            // CASE 05
            input = "   ((  ))  aa ";
            output = LTrim(input);
            Console.WriteLine($"5th Result:    {output.Equals("((  ))  aa ")}");

            Console.ReadKey();
        }

        public static string LTrim(string input)
        {
            StringBuilder output = new StringBuilder(input);
            bool foundLetter = false;

            int n = 0;
            while (true)
            {
                if (!input[n].Equals(' '))
                {
                    foundLetter = true;
                }
                if (!foundLetter)
                {
                    output.Remove(0, 1);
                }
                
                if (n.Equals(input.Length-1))
                    break;
                
                n++;
            }

            return output.ToString();
        }
    }
}
