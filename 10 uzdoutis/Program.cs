using System;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int A = int.Parse(Console.ReadLine());


            if ( A % 2 == 0)
            {
                if ( A > 20 )
                {
                  if(A % 4 == 0 )
                  {
                        Console.WriteLine("skaicius yra lyginis, disesnis uz 20 ir dalinasi is 4");
                  }
                }
               

            }
            else
            {
                Console.WriteLine("skaicius yra nelyginis");
            }
        }

    }
}






