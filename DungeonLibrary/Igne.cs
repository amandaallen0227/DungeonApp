using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Igne : Monster
    {
        //(Igne - Scoria[dark redish - color and porus.Created when thin lava is ejected from a volcano.This monster is faster but is easily broken apart - high hit - stregth, weak block], Pumice[light in color, it solidifies quickly and gas gets trapped in the melt at solidification time - hard to kill, normal hit stregth and block] Pegnatite[extremely course, BIG BOSS, solidifies slowly higher hit strength and harder to kill]

        //description, hit count, block count, max life
        public Igne(string name, int hitChance, int block, int maxLife, int life, int minDamage, int maxDamage, string description)
            : base(name, hitChance, block, maxLife, life, minDamage, maxDamage, description);

    } //end class
} //end namespace
