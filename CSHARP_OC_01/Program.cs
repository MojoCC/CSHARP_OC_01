using System;

namespace CSHARP_OC_01
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = Environment.UserName;

            string day = DateTime.Now.DayOfWeek.ToString();

            int hour = DateTime.Now.Hour;

            if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine("Bon weekend " + name + " !");

            } else
            {
                if (hour > 9 || hour < 18)
                {
                    Console.Write("Bonjour " + name + ".");
                }
                else if (hour > 18 || hour < 9)
                {
                    Console.WriteLine("Bonsoir " + name + ".");
                }
            }

            Console.ReadLine();
        }
    }
}
