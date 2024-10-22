using System;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite el.pasto adresa");
            string Adres = (Console.ReadLine());
            switch (Adres)
            {
                case "@gmail.com":
                    Console.WriteLine("popiuliarus el.pasto teikejas");
                    break;
                case "@yahoo.com":
                    Console.WriteLine("populiarus el.passto teikejas");
                    break;
                     default:

                       Console.WriteLine("tai yra maziau zinomas el.pasto teikejas");
                    break;

            }

        }


    }
}






