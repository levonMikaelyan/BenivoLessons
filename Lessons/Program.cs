using System;
using Lessons.Payment;

namespace Lessons
{
    class Program
    {
        static void Main()
        {
            bool isMarried = false; // 1 bit

            Console.WriteLine(isMarried.ToString().ToLower());

            string name = "Armen"; // 2 byte for each character - 10 byte == 80 bit

            char symbol =  'a' // 2 byte

            byte color = 255; // 1 byte == 8 bit 

            int id = 1000;  // 4 byte == 32 bit (Int 32)

            short id1 = 1234; // 2 byte == 16 bit (Int16)

            long id2 = 321323123123313;  // 8 byte == 64 bit (Int64)

            float size = 3.12f; // 4 byte

            double height = 4.32; // 8 byte

           decimal amount = 3.123m; // 16 byte

       

            DateTime birthday = DateTime.Now;




            Console.WriteLine();



          

                
           
        }
    }
}
