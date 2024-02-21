using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su edad:");
        double n1 = Convert.ToDouble(Console.ReadLine());

        if (n1 < 18)
        {
            Console.WriteLine("Lamentablemente usted no es apto para entrar a este club :c");
        }
        else
        {
            Console.WriteLine("Usted es apto para entrar al club, Felicidades !!!");
        }
    }
}
