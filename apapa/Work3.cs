using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apapa
{
    internal class Work3
    {
        static void Main()
        {
            Console.WriteLine("Input example: ");
            string input = Console.ReadLine();                 
            int result = CalculateExpression(input);            
            Console.WriteLine($"Result: {result}");
            static int CalculateExpression(string expression)
            {
                int result = 0;
                int num = 0;
                char operation = '+';

                foreach (char c in expression)
                {
                    if (char.IsDigit(c))
                    {
                        num = num * 10 + (c - '0');
                    }
                    else
                    {
                        result = operation == '+' ? result + num : result - num;
                        operation = c;
                        num = 0;
                    }
                }             
                result = operation == '+' ? result + num : result - num;
                return result;
            }
        }
    }
}
