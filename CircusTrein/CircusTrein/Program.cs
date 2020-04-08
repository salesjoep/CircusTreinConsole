using System;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Menu()
            {
                //Menu
                Console.WriteLine("Welkom bij het programma Circus Trein!");
                Console.WriteLine("Geef gegevens van de dieren hieronder door:\n");

                Console.WriteLine("Toets 1 voor vleeseters, toets 2 voor planteneters en toets 3 voor gemengd.\n");
                string menuKeuze = Console.ReadLine();
                if (menuKeuze == "1")
                {
                    Console.WriteLine("U heeft gekozen voor alleen vleeseters");
                    Console.WriteLine("Toets 1 voor alleen kleine dieren, toets 2 voor alleen middel,\ntoets 3 voor alleen grote en toets 4 voor gemengd");
                    string menuVleeseter = Console.ReadLine();

                    if (menuVleeseter == "1")
                    {
                        Console.WriteLine("U heeft gekozen voor alleen kleine vleeseters");
                        Console.ReadLine();
                    }
                    else if (menuVleeseter == "2")
                    {
                        Console.WriteLine("U heeft gekozen voor alleen middel vleeseters");
                        Console.ReadLine();
                    }
                    else if (menuVleeseter == "3")
                    {
                        Console.WriteLine("U heeft gekozen voor alleen grote vleeseters");
                        Console.ReadLine();
                    }
                }
                else if (menuKeuze == "2")
                {
                    Console.WriteLine("U heeft gekozen voor alleen planteneters");
                    Console.WriteLine("Toets 1 voor alleen kleine dieren, toets 2 voor alleen middel,\ntoets 3 voor alleen grote en toets 4 voor gemengd");
                    string menuPlanteneters = Console.ReadLine();

                    if (menuPlanteneters == "1")
                    {
                        Console.WriteLine("U heeft gekozen voor alleen kleine planteneters");
                        Console.ReadLine();
                    }
                    else if (menuPlanteneters == "2")
                    {
                        Console.WriteLine("U heeft gekozen voor alleen middel planteneters");
                        Console.ReadLine();
                    }
                    else if (menuPlanteneters == "3")
                    {
                        Console.WriteLine("U heeft gekozen voor alleen grote planteneters");
                        Console.ReadLine();
                    }
                }
                else if (menuKeuze == "3")
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

