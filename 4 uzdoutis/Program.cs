using System;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("irasykyte raide ");
            char raide = char.Parse(Console.ReadLine().ToLower());
            if (raide == 'a' || raide == 'e' || raide == 'i' || raide == 'o' || raide == 'u')
            {
                Console.WriteLine($"raide '{raide}' yra balse");

            }
            else
            {
                Console.WriteLine($"raide '{raide}' yra priebalse");
            }
        }

    }
}






