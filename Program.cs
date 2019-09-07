
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBiDiagAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            GetOutput();
            
            Console.ReadKey();
        }

        private static void TryAgain()
        {
            Console.WriteLine("Try another input?? Press 1 if yes otherwise 0");
            var decision = Console.ReadLine();
            if (decision == "1")
            {
                GetOutput();
            }
            else
            {
                Console.WriteLine("Terminated");
            }
        }

        private static void GetOutput()
        {
            Console.WriteLine("Please enter input value");

            string input = Console.ReadLine();
            var inputVal = Convert.ToInt32(input);

            int startElement = 1;
            int initialDiff = inputVal - 1;
            int totalSum = 0;
            bool isInputOddNumber = IsGivenNumberOdd(inputVal);

            while (initialDiff >= 1)
            {
                var sum = GetSum(startElement, initialDiff);
                var last = GetLastElement(startElement, initialDiff);
                totalSum += sum;
                startElement = last + initialDiff;
                initialDiff = initialDiff - 2;
            }

            if (isInputOddNumber == true)
            {
                Console.WriteLine(totalSum + inputVal * inputVal);
            }
            else
                Console.WriteLine(totalSum);
            TryAgain();
        }

        private static int GetSum(int startElement, int initialDiff)
        {
            int sum = 0;

            for (int i = 0; i < 4; i++)
            {
                var nextElement = startElement + i * initialDiff;
                sum += nextElement;
            }

            return sum;
        }

        private static int GetLastElement(int startElement, int initialDiff)
        {
            int lastelement = 0;

            lastelement = startElement + 3 * initialDiff;

            return lastelement;
        }

        private static bool IsGivenNumberOdd(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
