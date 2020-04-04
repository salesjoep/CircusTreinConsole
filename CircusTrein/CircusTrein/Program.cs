using System;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            void Menu()
            {
                string menukeuze;

                //Menu
                Console.WriteLine("Welkom bij het programma Circus Trein!");
                Console.WriteLine("Geef gegevens van de dieren hieronder door:\n");

                Console.WriteLine("Toets 1 voor vleeseters, toets 2 voor planteneters en toets 3 voor gemengd.\n");
                menukeuze = Console.ReadLine();
                if (menukeuze == "1")
                {
                    Console.WriteLine("U heeft gekozen voor alleen vleeseters");
                    Console.ReadLine();
                }
                else if (menukeuze == "2")
                {
                    Console.WriteLine("U heeft gekozen voor alleen planteneters");
                    Console.ReadLine();
                }
                else if (menukeuze == "3")
                {
                    Console.WriteLine("U heeft gekozen voor gemengd");
                    Console.ReadLine();
                }
            }
            //Start van het programma
            Menu();

        }
    }
}
