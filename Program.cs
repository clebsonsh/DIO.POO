using System;
using DIO.POO.src.Entities;

namespace DIO.POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 23, "Knight");
            Console.WriteLine(hero);
        }
    }
}
