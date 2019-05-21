using System;
using Lessons.Payment;

namespace Lessons
{
    class Program
    {
        static void Main()
        {
           Console.WriteLine("Hellow Otter");

            PayPal.Pay(100);
            PayPal.Pay(50);
            PayPal.Pay(500);
        }
    }
}
