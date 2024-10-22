using System;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("irasykyte savo varda");
            string vardas = (Console.ReadLine());


            if (vardas > 5)
            {
                Console.WriteLine("turi daugiau nie 5 simbolius");

            }
            else
            {
                Console.WriteLine("turi maziau nie 5 simbolius");
            }
        }

    }
}






