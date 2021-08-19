using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //(Igne - inspired by Igneous Rock 
    //Scoria[dark redish - color and porus.Created when thin lava is ejected from a volcano.This monster is faster but is easily broken apart - high hit - stregth, weak block], 
    //Pumice[light in color, it solidifies quickly and gas gets trapped in the melt at solidification time - hard to kill, normal hit stregth and block
    //Pegnatite[extremely course, BIG BOSS, solidifies slowly higher hit strength and harder to kill]

    public class Igne : Monster
    {
        public bool isRunning { get; set; }

        //description, hit count, block count, max life
        public Igne(string name, int hitChance, int block, int life, int maxLife, int minDamage, int maxDamage, string description, bool IsRunning)
            : base(name, hitChance, block, life, maxLife, minDamage, maxDamage, description)
        {
            IsRunning = isRunning;
            if (true)
            {
                Block -= 5; //decreases block functionality - easier to break a part when moving faster
                HitChance += 10; //increas hitchance because moving faster
                Description += "\nIt's running right at you!";
            } //end if
        } //end ctor

    } //end class
} //end namespace
