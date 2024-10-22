using System;
using System.ComponentModel.Design;

namespace IfSalygosSakiniai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            int A = int.Parse(Console.ReadLine());

            if (A > 0 && A >100)
            {
                
                
                    if (A * A > 10000)
                    {
                        Console.WriteLine("ypatingas, didelis ir dalinasi is 10");

                    }
                

                    else
                    {
                      Console.WriteLine("paprastas");
                    }

                
                   




                




            }
        }

    }
}






