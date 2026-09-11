using System;
using System.Collections.Generic;
using System.Text;

namespace WUWA_CHARACTER_OOP
{
    internal class ClaymoreChar : Character, IIDamageDealer, IHealer, ISupport
    {
        public double ATKSpeed { get; set; }
        public ClaymoreChar(string name, string weapon, string element, double hp, double atk, double def, double crit_rate, double crit_damage, string role, double atk_speed) : base(name, "Claymore", element, hp, atk, def, crit_rate, crit_damage, role)
        {
            ATKSpeed = atk_speed;
        }
        public override double GetDamage()
        {
            return (ATK * (1 + CritRate * CritDamage / 100)) * 2.0;
        }
        public override void PrintStats()
        {
            Console.WriteLine($"Name: {Name}\nWeapon: {Weapon}\nElement: {Element}\nHP: {HP}\nATK: {ATK}\nDEF: {DEF}\nCrit Rate: {CritRate}\nCrit Damage: {CritDamage}\nATK Speed: {ATKSpeed}\nRole: {Role}");
        }
    }
}
