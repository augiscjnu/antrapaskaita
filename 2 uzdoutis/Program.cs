Console.WriteLine("Iveskite amziu");
int amzius = int.Parse(Console.ReadLine());
if (amzius <13)
{
    Console.WriteLine("esate vaikas");
}
else if (amzius <18)
{
    Console.WriteLine("jus esate paauglys");
}
else if (amzius >18 )
{
    Console.WriteLine("jus esate suages");
}
else if( amzius >=18 && amzius < 65) 
{
    Console.WriteLine("jus esate senjoras");

}