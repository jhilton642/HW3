using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0;
            int secondNum = 1;
            Console.WriteLine("Enter how many Fibonacci numbers do you want to see? ");
            string howMany = Console.ReadLine();
            int howManyNums = Convert.ToInt32(howMany);
            Console.WriteLine(firstNum);
            for (int i = 2; i <= howManyNums; i++)
            {
                int temp = firstNum;
                firstNum = firstNum + secondNum;
                secondNum = temp;
                Console.WriteLine(firstNum);
            }
        }
    }
}
