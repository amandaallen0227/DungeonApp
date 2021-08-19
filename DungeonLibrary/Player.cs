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

            public Player (string name, int hitChance, int block, int life, int maxLife, Race playerRace, Weapon equippedWeapon)
                : base(name, hitChance, block, life, maxLife)
            {
                PlayerRace = playerRace;
                EquippedWeapon = equippedWeapon;
                switch (PlayerRace)
                {
                    case Race.Human:
                        hitChance += 10;
                        block += 8;
                        MaxLife += 12;
                        break;
                    case Race.Mongrel: // half Abaddon half Igne (half hero half enemy)
                        hitChance += 15;
                        block += 25;
                        MaxLife += 20;
                        break;
                    case Race.Giants: //half human half Abaddon
                        hitChance += 20;
                        block += 10;
                        MaxLife += 5;
                        break;
                    case Race.Abaddon: //the strongest alien race
                        hitChance += 25;
                        block -= 20;
                        MaxLife += 15;
                        break;                

                } //end switch

            }//end Ctor

            public override string ToString()
            {
                return string.Format($"{Name}\nRace: {PlayerRace}\nWeapon: {EquippedWeapon}\nLife: {Life} to {MaxLife}\nHit Chance: {HitChance}%\n" + $"Block Chance: {Block}%");
            }

            //public override int CalcDamage()
            //{
            //    Random rand = new Random();
            //    int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //    return damage;
            //} //end method

            //public override int CalcHitChance()
            //{
            //    return HitChance + EquippedWeapon.BonusHitChance;
            //}

        } //end class

} //end namespace
