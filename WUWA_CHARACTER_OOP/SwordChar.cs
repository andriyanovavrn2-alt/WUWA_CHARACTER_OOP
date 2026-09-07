using System;
using System.Collections.Generic;
using System.Text;

namespace WUWA_CHARACTER_OOP
{
    internal class SwordChar : Character
    {
        public double ATKSpeed { get; set; }
        public SwordChar(string name, string weapon, string element, double hp, double atk, double def, double crit_rate, double crit_damage, string role, double atk_speed) : base(name, "Sword", element, hp, atk, def, crit_rate, crit_damage, role)
        {
            ATKSpeed = atk_speed;
        }
        public override double GetDamage()
        {
            return base.GetDamage() * 1.1;
        }
        public override void PrintStats()
        {
            Console.WriteLine($"Name: {Name}\nWeapon: {Weapon}\nElement: {Element}\nHP: {HP}\nATK: {ATK}\nDEF: {DEF}\nCrit Rate: {CritRate}\nCrit Damage: {CritDamage}\nATK Speed: {ATKSpeed}\nRole: {Role}");
        }
    }
}
