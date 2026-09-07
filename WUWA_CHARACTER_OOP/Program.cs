using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using WUWA_CHARACTER_OOP;

namespace _30_08_26_stepic
{
    internal class Program
    {
        public static void Main()
        {
            List<Character> char_list = new List<Character>();
            const double hp = 10_000;
            const double atk = 500;
            const double def = 1_500;
            const double crit_rate = 5;
            const double crit_dmg = 50;
            while (true)
            {
                Console.WriteLine("-----Main Menu-----");
                Console.WriteLine("Hi! Chose the number:");
                Console.WriteLine("1.Create your character.\n2.Show all characters (names).\n3.Show ditales chose character\n4.Delete character.\n5.Exit.");
                Console.WriteLine("So, you chose:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter character weapon:\nSword / Claymore ");
                        string choice_weapon = Console.ReadLine();
                        Console.WriteLine("Enter character name: ");
                        string name_char = Console.ReadLine();
                        Console.WriteLine("Enter character element: ");
                        string elem_char = Console.ReadLine();
                        Console.WriteLine("Enter character role: ");
                        string role_char = Console.ReadLine();
                        if (choice_weapon == "Sword" || choice_weapon == "sword")
                        {
                            Character sword_char = new SwordChar(name_char, choice_weapon, elem_char, hp, atk, def, crit_rate, crit_dmg, role_char, 25);
                        }
                        else if (choice_weapon == "Claymore" || choice_weapon == "claymore")
                        {

                        }


                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("All character");
                        foreach (var i in char_list)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Ditales of character");
                        break;
                    case "4":
                        Console.WriteLine("Enter character for delete");
                        break;
                    case "5":
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("Uncorrect enter!");
                        break;
                }
            }
        }
    }
}
