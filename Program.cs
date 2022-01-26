using System;
using DIO.POO.src.Entities;

namespace DIO.POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Mage jenica = new Mage("Jenica", 23, "White Mage");
            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jenica);
            Console.WriteLine(jenica.Attack(2));
        }
    }
}
