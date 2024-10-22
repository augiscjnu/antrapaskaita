using System;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite dvizenkli skaiciu");
            int A =int.Parse (Console.ReadLine());


            if (A > 0 )
            {
                Console.WriteLine("skaicius yra lyginis");

            }
            else
            {
                Console.WriteLine("skaicius yra nelyginis");
            }
        }

    }
}






