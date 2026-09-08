using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
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
        public static void PrintAllChar(List<Character> char_list)
        {
            Console.WriteLine("All character: ");
            for (int i = 0; i < char_list.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {char_list[i].Name}");
            }
        }


        public static void Main()
        {
            bool flag = true;
            List<Character> char_list = new List<Character>();

            const double hp = 10_000;
            const double atk = 500;
            const double def = 1_500;
            const double crit_rate = 5;
            const double crit_dmg = 50;
            while (flag)
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
                            char_list.Add(sword_char);
                        }
                        else if (choice_weapon == "Claymore" || choice_weapon == "claymore")
                        {
                            Character claymore_char = new ClaymoreChar(name_char, choice_weapon, elem_char, hp, atk, def, crit_rate, crit_dmg, role_char, 15);
                            char_list.Add(claymore_char);
                        }
                        Console.WriteLine("Your character add in list!");
                        Console.WriteLine("\n\n");
                        break;
                    case "2":
                        if (char_list.Count == 0)
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        else
                            PrintAllChar(char_list);
                        Console.WriteLine("\n\n");
                        break;
                    case "3":
                        if (char_list.Count == 0)
                        {
                            Console.WriteLine("The list is empty.");
                        }
                        else
                            PrintAllChar(char_list);

                        Console.WriteLine("\n");
                        Console.WriteLine("Chose the character (enter the character number): ");
                        int choice_num = Convert.ToInt32(Console.ReadLine());
                        if (choice_num > char_list.Count || choice_num <= 0)
                        {
                            Console.WriteLine("Uncorrect character number!");
                        }
                        else
                        {
                            char_list[choice_num - 1].PrintStats();
                            Console.WriteLine("Ditales of character: ");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter character for delete");
                        break;
                    case "5":
                        Console.WriteLine("Bye");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Uncorrect enter!");
                        break;
                }
            }
        }

    }
}
