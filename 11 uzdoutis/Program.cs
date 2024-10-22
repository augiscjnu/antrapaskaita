using System;
using System.ComponentModel.Design;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo amziu");
            int A = int.Parse(Console.ReadLine());

            if (A >=18 && A<=36 )
            {
                Console.WriteLine("ar esate studentas");
                
                {
                    Console.ReadLine();
                    bool taip = true;
                    if (taip)
                        Console.WriteLine("jums priklauso stipendija");


                    else
                    {
                        Console.WriteLine("galite pretenduoti i akademine parama");
                    }
                   
                    

                    
                }

            
            
            
            }
        }

    }
}






