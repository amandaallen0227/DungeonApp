using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character //abstract so that the compiler knows this is an incomplete implementation
    {
        //fields
        private int _life;

        //properties
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }

        public int Life
        { get { return _life; }
            set
            {
                _life = value > MaxLife ? MaxLife : value;
            } //end set           

        } //end life

        public Character(string name, int hitChance, int block, int maxLife, int life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
        } //end ctor

        public virtual int CalcBlock()
        {
            return Block;
        } //end method 

        public virtual int CalcHitChance()
        {
            return HitChance;
        } //end method

        public abstract int CalcDamage(); //method stub (has no body) we don't have any default functionality


    } //end class

} //end namespace
