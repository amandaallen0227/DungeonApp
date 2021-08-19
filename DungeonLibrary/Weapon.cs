using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //fields
        private int _minDamage;
        
        //properties
        public string Name { get; set; }
        public int BonusHitChance { get; set; }
        public int MaxDamage { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }
        }

        public Weapon(string name, int bonusHitChance, int minDamage, int maxDamage)
        {
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        } //end CTOR

        public override string ToString()
        {
            return string.Format($"{Name}\n " +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Hit Modifier: {BonusHitChance}\n"); 
        }


    } //end class
} //end namespace
