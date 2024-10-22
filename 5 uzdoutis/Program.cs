using System;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("irasykyte pirma skiaciu ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("irasykite antra skaiciu");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("irasykyte trecia skaiciu");
            int C = int.Parse(Console.ReadLine());


            if (A < (B + C) || B < (A + C) || C < (A + B)) 
            {
                Console.WriteLine("sie skaiciai sudaro trikampi");

            }
            else
            {
                Console.WriteLine("sie skaiciai nesudaro trikampio");
            }
        }

    }
}






