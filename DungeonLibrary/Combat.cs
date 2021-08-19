using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        //remember this just houses the method functionality

        public static void Attack(Character attacker, Character defender)
        {
            //Use a dice roll from 1-100 to use as a basis to determine if the attacker hits:
            int diceroll = new Random().Next(1, 101);

            //The Sleep() allows us to pause the execution ofcode for a defined number 
            //of milliseconds (1 thousand of these is 1 sec)

            System.Threading.Thread.Sleep(35);
            if (diceroll <= attacker.CalcHitChance() - defender.CalcBlock())
            {
               int damageDealt = attacker.CalcDamage(); //here is how much damage we are doing
            defender.Life -= damageDealt; //this is assigning to new Life after the damage is done

              Console.ForegroundColor = ConsoleColor.Red; //changing color for the displayed damage
              Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!"); //display
              Console.ResetColor();
        }
            else
           {
                Console.WriteLine($"{attacker.Name} missed!");
            } //end else 


        } //end attack

        public static void Battle(Player player, Monster monster)
        {
            Attack(player, monster);
            if (monster.Life > 0)
            {
                Attack(monster, player);
            } //end if
        } //end battle()

    } //end class
} //end namespace
