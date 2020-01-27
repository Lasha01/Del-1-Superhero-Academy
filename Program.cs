using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Del_1_Superhero_Academy
{
    class Program
    {
        public static List<Superheroes> heroes = new List<Superheroes>(); //Skapar en lista där hjältarna läggs in
        static Random rng = new Random();

        static void Main(string[] args)

        {
            Mage mage = new Mage(); //Skapar hjälten
            heroes.Add(mage); //Lägger in hjälten i listan
            Knight knight = new Knight();
            heroes.Add(knight);
            Ninja ninja = new Ninja();
            heroes.Add(ninja);



            Console.WriteLine("Hello superhero! What's your name?");

            string name = Console.ReadLine();


            Console.WriteLine(name);
            Console.ReadLine();

        }
        int ChooseHero(string message)
        {
            int choice = 1;
            while (true)
            {
                Console.WriteLine(message);
                for (int i = 0; i < heroes.Count; i++) //Körs så många gånger som heroes finns
                {
                    Console.WriteLine(" " + heroes[i].skill()); //Skriver ut listorna
                }
            }
        }
    }
}


