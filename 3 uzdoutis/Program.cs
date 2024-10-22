   using System;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savaites dienos numeri");
            string diena = (Console.ReadLine());
            switch (diena)
            {
                case "1":
                    Console.WriteLine("siandien yra pirmadienis");
                    break;
                case "2":
                    Console.WriteLine("siandien yra antradienis");
                    break;
                case "3":
                    Console.WriteLine("siandien yra treciadienis");
                    break;
                case "4":
                    Console.WriteLine("siandien yra ketvirtadienis");
                    break;
                case "5":
                    Console.WriteLine("siandien yra penktadienis");
                    break;
                case "6":
                    Console.WriteLine("siandien yra sestadienis");
                    break;
                case "7":
                    Console.WriteLine("siandien yra sekmadienis");
                    break;
                default:
                    Console.WriteLine("tai nera savaites diena");
                    break;

                
            }

        }


    }
}
            

            

        
    
