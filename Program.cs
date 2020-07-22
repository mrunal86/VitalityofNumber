using System;
namespace VitalityofNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int count;
            Console.WriteLine(GetProduct(num, out count));
                
            Console.ReadLine();
        }

        private static int GetProduct(int num, out int count)
        {
            int product = 1;
            count = 1;
            int digit = 0;
            if (num.ToString().Contains(digit.ToString()))
            { return 1; }
               
            else
            {
                product = product * (num / 10);
                num = num / 10;
                count++;
            }
            return count;
        }

         
    }
}
