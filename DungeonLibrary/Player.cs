using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
   

        public class Player : Character
        {
            public Race PlayerRace { get; set; }
            public Weapon EquippedWeapon { get; set; }

            public Player(string name, int hitChance, int block, int life, int maxLife, Race playerRace, Weapon equippedWeapon)
                : base(name, hitChance, block, life, maxLife)
            {
                PlayerRace = playerRace;
                EquippedWeapon = equippedWeapon;
                switch (PlayerRace)
                {
                    case Race.Human:
                        hitChance += 15;
                        block += 5;
                        MaxLife += 5;
                        break;
                    case Race.Halfling:
                        hitChance += 8;
                        block += 15;
                        MaxLife += 5;
                        break;
                    case Race.Giants:
                        block += 10;
                        MaxLife += 15;
                        break;
                    case Race.Abaddon://Goblin -bigger strong higher hitdamage, low block
                        hitChance += 15;
                        block -= 3;
                        MaxLife += 15;
                        break;                

                } //end switch

            }//end Ctor

            public override string ToString()
            {
                return string.Format($"{Name}\nRace: {PlayerRace}\nWeapon: {EquippedWeapon}\nLife: {Life} to {MaxLife}\nHit Chance: {HitChance}%\n" + $"Block Chance: {Block}%");
            }

            public override int CalcDamage()
            {
                Random rand = new Random();
                int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
                return damage;
            } //end method

            public override int CalcHitChance()
            {
                return HitChance + EquippedWeapon.BonusHitChance;
            }


    } //end class

} //end namespace
