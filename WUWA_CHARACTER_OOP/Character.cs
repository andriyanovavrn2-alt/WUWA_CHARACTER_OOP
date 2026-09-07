using System;
using System.Collections.Generic;
using System.Text;
using WUWA_CHARACTER_OOP;

namespace WUWA_CHARACTER_OOP
{
    internal class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Weapon { get; set; }
        public string Element { get; set; }
        public double HP { get; set; }
        public double ATK { get; set; }
        public double DEF { get; set; }
        public double CritRate { get; set; }
        public double CritDamage { get; set; }
        public string Role { get; set; }
        public Character(string name, string weapon, string element, double hp, double atk, double def, double crit_rate, double crit_damage, string role)
        {
            Name = name;
            Weapon = weapon;
            Element = element;
            HP = hp;
            ATK = atk;
            DEF = def;
            CritRate = crit_rate;
            CritDamage = crit_damage;
            Role = role;
        }
        public void LevelUp()
        {
            Level += 1;
        }
        public virtual double GetDamage()
        {
            return ATK * (1 + CritRate * CritDamage / 100);
        }
        public virtual void PrintStats()
        {
            Console.WriteLine($"Имя: {Name}\nОружие: {Weapon}\nЭлемент: {Element}\nХП: {HP}\nАТК: {ATK}\nЗащита: {DEF}\nКрит Шанс: {CritRate}\nКрит Урон: {CritDamage}\nРоль: {Role}");
        }
    }
}
