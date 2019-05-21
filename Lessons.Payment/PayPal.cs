using System;

namespace Lessons.Payment
{
    public class PayPal
    {
        public static void Pay(int amount)
        {
            // Console.WriteLine("Paid " + amount + " succesfylly with PayPal!");
            //Console.WriteLine("Paid {0} succesfylly with PayPal!", amount);
            Console.WriteLine($"Paid ${amount} succesfylly with PayPal!");
        }

    }
}
