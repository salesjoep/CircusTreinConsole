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
                    Keuze_1();
                }
                else if (menuKeuze == "2")
                {
                    Keuze_2();
                }
                else if (menuKeuze == "3")
                {
                    Keuze_3();
                }
            }

            static void Keuze_3()
            {
                Console.WriteLine("U heeft gekozen voor gemengd");
                Console.WriteLine("Voer een naam in");
                string name = Console.ReadLine();
                Animals animal = new Animals(name, AnimalSize.Large, AnimalDiet.Herbivore);
                Console.WriteLine("Voer een grootte in");
                string size = Console.ReadLine();
                if (size == "small")
                {
                    animal.Size = AnimalSize.Small;
                    Console.WriteLine("Voer een dieet in, kies uit 'vlees' of 'planten'");
                    string dieet = Console.ReadLine();
                    if (dieet == "vlees")
                    {
                        animal.Diet = AnimalDiet.Carnivore;
                        Console.ReadLine();
                    }
                    if (dieet == "planten")
                    {
                        animal.Diet = AnimalDiet.Herbivore;
                        Console.ReadLine();
                    }
                }
                if (size == "medium")
                {
                    animal.Size = AnimalSize.Medium;
                    Console.WriteLine("Voer een dieet in, kies uit 'vlees' of 'planten'");
                    string dieet = Console.ReadLine();
                    if (dieet == "vlees")
                    {
                        animal.Diet = AnimalDiet.Carnivore;
                        Console.ReadLine();
                    }
                    if (dieet == "planten")
                    {
                        animal.Diet = AnimalDiet.Herbivore;
                        Console.ReadLine();
                    }
                }
                if (size == "large")
                {
                    animal.Size = AnimalSize.Large;
                    Console.WriteLine("Voer een dieet in, kies uit 'vlees' of 'planten'");
                    string dieet = Console.ReadLine();
                    if (dieet == "vlees")
                    {
                        animal.Diet = AnimalDiet.Carnivore;
                        Console.ReadLine();
                    }
                    if (dieet == "planten")
                    {
                        animal.Diet = AnimalDiet.Herbivore;
                        Console.ReadLine();
                    }
                }
            }

            static void Keuze_2()
            {
                Console.WriteLine("U heeft gekozen voor alleen planteneters");
                Console.WriteLine("Toets 1 voor alleen kleine dieren, toets 2 voor alleen middel,\ntoets 3 voor alleen grote en toets 4 voor gemengd");
                string menuPlanteneters = Console.ReadLine();

                if (menuPlanteneters == "1")
                {
                    Console.WriteLine("U heeft gekozen voor alleen kleine planteneters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animals kleinePlanteneter = new Animals(name, AnimalSize.Small, AnimalDiet.Herbivore);
                }
                else if (menuPlanteneters == "2")
                {
                    Console.WriteLine("U heeft gekozen voor alleen middel planteneters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animals middelPlanteneter = new Animals(name, AnimalSize.Medium, AnimalDiet.Herbivore);
                }
                else if (menuPlanteneters == "3")
                {
                    Console.WriteLine("U heeft gekozen voor alleen grote planteneters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animals grotePlanteneter = new Animals(name, AnimalSize.Large, AnimalDiet.Herbivore);
                }
            }

            static void Keuze_1()
            {
                Console.WriteLine("U heeft gekozen voor alleen vleeseters");
                Console.WriteLine("Toets 1 voor alleen kleine dieren, toets 2 voor alleen middel,\ntoets 3 voor alleen grote en toets 4 voor gemengd");
                string menuVleeseter = Console.ReadLine();

                if (menuVleeseter == "1")
                {
                    Console.WriteLine("U heeft gekozen voor alleen kleine vleeseters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animals kleineVleeseter = new Animals(name, AnimalSize.Small, AnimalDiet.Carnivore);
                }
                else if (menuVleeseter == "2")
                {
                    Console.WriteLine("U heeft gekozen voor alleen middel vleeseters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animals middelVleeseter = new Animals(name, AnimalSize.Medium, AnimalDiet.Carnivore);
                }
                else if (menuVleeseter == "3")
                {
                    Console.WriteLine("U heeft gekozen voor alleen grote vleeseters");
                    Console.WriteLine("Voer een naam in");
                    string name = Console.ReadLine();
                    Animals groteVleeseter = new Animals(name, AnimalSize.Large, AnimalDiet.Carnivore);
                }
            }
            Console.ReadKey();
            //Start van het programma
            Menu();

        }
    }
}

