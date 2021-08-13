using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            } //end set
        } //end minDamage

        public Monster(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, maxLife, life)
        {
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;
        }

        public override string ToString()
        {
            return string.Format($"{Name}\n{Description}\n" +
                $"Min-Max Life {Life} to {MaxLife}" +
                $"\nHit Chance: {HitChance}%\n" +
                $"Block: {Block}%");
        } //end ToString()

        //public override int CalcDamage()
        //{
        //    return new Random().Next(MinDamage, MaxDamage + 1);
        //}


    } //end class

} //end namespace
