using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string op;

            try
            {
                Console.Write("Enter the first integer: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second integer: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Enter the operator: ");
                op = Console.ReadLine();

                if (String.Compare(op, "+") == 0)
                {
                    Console.WriteLine("The sum is: {0} ", num1 + num2);
                }
                else if (String.Compare(op, "-") == 0)
                {
                    Console.WriteLine("The difference is: {0} ", num1 - num2);
                }
                else if (String.Compare(op, "*") == 0)
                {
                    Console.WriteLine("The product is: {0} ", num1 * num2);
                }
                else if (String.Compare(op, "/") == 0 && num2 != 0)
                {
                    Console.WriteLine("The quotient is: {0} ", num1 / num2);
                }
                else if (String.Compare(op, "/") == 0 && num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is undefined.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
