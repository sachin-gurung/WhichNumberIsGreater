using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichNumberIsGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            Console.Write("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
                Console.WriteLine(firstNumber + " is greater than " + secondNumber);
            else
                Console.WriteLine(secondNumber + " is greater than " + firstNumber);

        }
    }
}
/*
Sample Result:

Enter first number: 65
Enter second number: 45
65 is greater than 45
Press any key to continue . . .
*/