using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string heroName;
            Race heroRace = Race.Abaddon;
            int killCount = 0;

            Console.Title = " ~ ~ ~ The Legend of Abaddon ~ ~ ~ ";
            Console.WriteLine("On a not so distant planet there lived a race of being called Abaddon. They were the strongest and most fierce warriors in all the galaxy. To look on them would be to gaze into the burning sun. Though many feared this race, most praised them for their service and good to all that were peaceable to them.\n");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("The only race unpeaceful towards them were the Igneous; a species made from the ground and held together by the darkness and disaster that created them. For an Igne they lived a life dispised by all and set a part from all others. ");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("Like the Abaddon, they were feared. But misunderstood. You see the Igneous people were not evil nor did they hate anyone, they were simple done being held down.");
        
            Console.Write("What is your name: ");
            heroName = Console.ReadLine();
            Console.Clear();

            bool raceMenu = true;
            do
            {
                Console.WriteLine($"{heroName}, choose your race:\n\n" +
                    "A)baddon - A beautiful celesial being from a far planet: Highest hit chance, medium block\n" +
                    "G)iant - Half Human half Abaddon: High hit chance, medium block\n" +
                    "H)uman - Low hit chance, low block, medium life\n" +
                    "M)ongrel - Half Abaddon half Igne: Highest block, medium hit chance \n");
                ConsoleKey raceChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (raceChoice)
                {
                    case ConsoleKey.A:
                        heroRace = Race.Abaddon;
                        raceMenu = false;
                        break;

                    case ConsoleKey.G:
                        heroRace = Race.Giant;
                        raceMenu = false;
                        break;

                    case ConsoleKey.H:
                        heroRace = Race.Human;
                        raceMenu = false;
                        break;

                    case ConsoleKey.M:
                        heroRace = Race.Mongrel;
                        raceMenu = false;
                        break;
                 
                    default:
                        Console.WriteLine($"{raceChoice} was not a valid option. Please choose again.");
                        break;
                }



            } while (raceMenu);

            Console.Clear();

            Console.WriteLine($"You have chosen {heroRace}. ");
            System.Threading.Thread.Sleep(2500);           
            Console.WriteLine($"{heroName}...\nYou have just crash landed on an unknown planet.");
            System.Threading.Thread.Sleep(2500);

            Console.WriteLine("You open the hatch to your pod and find yourself in an unknown world...\n");
            System.Threading.Thread.Sleep(2500);


            Weapon javelin = new Weapon("Javelin", 5, 5, 8);
            Player player = new Player(heroName, 25, 15, 10, 25, Race.Human, javelin);

            bool exit = false;
            do
            {

               

                Console.WriteLine(Location.GetLocation());
                Igne Scoria = new Igne("Scoria!", 23, 5, 15, 30, 10, 12, "A rock monster with a porus outerlay, dark and redish in color", true);

                Igne Pumice = new Igne("Pumice!", 15, 20, 15, 55, 8, 12, "Almost translucent this light colored beast has a hard out shell but when proded spews hot magma and gas", false);

                Igne Pegnatite = new Igne("Pegnatite!", 26, 25, 10, 30, 10, 15, "Extremely course and almost indestructible", false);

                Monster Sera = new Monster("Sera!", 12, 10, 1, 25, 12, 16, "Engulfed in continuous fire that never consumes. Fuled by fire this monster requires a javelin to be destroyed");

                Monster Cheru = new Monster("Cheru!", 12, 20, 5, 30, 8, 14, "Souring through the air with stretched out wings");

                Monster Arch = new Monster("Arch!", 20, 20, 5, 25, 15, 15, "A strong, bright, and hairy beast");

                Monster[] monsters =
                {
                    Scoria, Pumice, Pumice, Pumice, Scoria, Sera, Sera, Cheru, Cheru, Arch, Pegnatite
                };
                Random rand = new Random();
                int index = rand.Next(monsters.Length);
                Monster monster = monsters[index];
                Console.WriteLine("\nYou see " + monster.Name + "\n" + monster.Description +"!");

                bool reload = false;
                do
                {
                    Console.Title = $"Life: {player.Life}";
                    Console.WriteLine("\nChoose your action:\n" +
                        "A)ttack\n" +
                        "F)lee\n" +
                        "V)iew Player Stats\n" +
                        "M)onster Stats");

                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.Battle(player, monster);
                            if (monster.Life <= 0)
                            {

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("The Monster in dead. You need to begin your journey to a new land.");                              
                                Console.ResetColor();
                                reload = true;                              
                                killCount++;
                                System.Threading.Thread.Sleep(2000);
                            } //end if
                            break;

                        case ConsoleKey.F:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Retreat!");
                            Console.ResetColor();
                            Console.WriteLine($"The {monster.Name} attack you as you flee!");
                            Combat.Attack(monster, player);
                            reload = true;
                            break;

                        case ConsoleKey.V:
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("You have sacrificed yourself.");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Chose a different option...");
                            break;
                    } //end switch

                    if (player.Life <= 1)
                    {
                        Console.WriteLine($"You have been killed by the {monster.Name}.");
                        exit = true;
                    } //end if



                } while (!reload && !exit);
 

            } while (!exit); //remember it is true that the exit is NOT true

            bool replay = true;
            do
            {
                Console.Title = (" Game Over ");
                Console.WriteLine("Would you like to play again? Y/N");

                ConsoleKey userAnswer = Console.ReadKey().Key;
                Console.Clear();

                switch (userAnswer)
                {
                    case ConsoleKey.Y:
                        raceMenu = true;
                        break;

                    default:
                        Console.WriteLine("Until we meet again...");
                        break;

                }

            } while (!replay && !exit);
           

            Console.WriteLine("GAME OVER!");
            Console.ReadLine();
            

        } //end main()

    } //end class

} //end namespace
