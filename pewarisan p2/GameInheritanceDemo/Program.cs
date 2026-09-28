using System;

namespace GameInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO INHERITANCE ===\n");

            Console.WriteLine("1. Membuat objek warrior (dengan konstruktor berparameter)");
            Warrior warrior = new Warrior(50, "W-001","Arthas", 100, "stormwind" );
            warrior.DisplayData3();

            Console.WriteLine("\n2. Membuat objek mage (dengan konstruktor berparameter) ");
            Mage mage = new Mage(80, "M-001", "Jaina", 90, "Dalaran");
            mage.DisplayData();

            Console.WriteLine("\n3. Membuat objek Archmage (dengan konstruktor berparameter)");
            ArchMage archmage = new ArchMage(120, 80, "AM-001", "Khadgar", 110, "Karazhan");
            archmage.DisplayData1();

            Console.WriteLine("\n4. Membuat  objek warrior dengan konstruktor default");
            Warrior defaultWarrior = new Warrior();
            defaultWarrior.DisplayData3();




            Console.ReadKey();



        }
    }
}