using static System.Runtime.InteropServices.JavaScript.JSType;

namespace algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            string number = Console.ReadLine();
            int intnumber = Convert.ToInt32(number);
            int sum = 0;
            for (int i = 1; i < intnumber; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine(sum);


        }


    }
}