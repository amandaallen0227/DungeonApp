using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Location
    {
        public static string GetLocation()
        {
            string[] locations =
                { 
            //the city on Fire:EDOM
            "You walk forward through the weak portal at the end of a long cave system. The land is burning, literally.\n " +
            "Fires wreak havoc to everything that's even remotely alive, which by now is very little. You realize,\n" +
            "you are in EDOM. A wave of nostalgia hits you, somehow you feel at home. Even with these rough conditions \n" +
            "you're at ease and you feel secure here. Nearby you hear songs and growls of the strangest creatures \n" +
            "you could've imagined. Many of them keep their distance from you, you try to avoid getting too close... ",

            //the world of death and the grave: Sheol
            "You move forward through the enticing portal previously locked. With each step you take you slide forward a\n" +
            "little more. Ice covers everything. It seems as if there is not life here. As you enter this city you see a\n " +
            "sign that says 'SHEOL / the city of death'. This world is clearly treacherous, but with great risks come great\n" +
            "rewards. In the nearby proximity you see strange shapes of beings you thought only existed in the minds of \n " +
            "dreamers. There's definitely some hostility going on, you keep your guard up just to be safe... ",

            //The land of Uz
            "You cautiously venture torward a sacred temple. You're immediately met by a foreboding city.\n" +
            "Rocks cover virtually every surface you can see, which makes traversing this landscape tricky\n" +
            "and dangerous. You could've sworn something touched your leg just now. The LAND OF UZ is no picnic.\n" +
            "Not all the creatures seem content with your presence, one begins to come towards you...\n",

            //Laodicea - a self loving self  protecting land. There a constant need for distraction and comfort
            "You stride forward through a dark forest and you're immediately met by gentle slow blurring your vision.\n" +
            "Snowflakes gently glide by, they cover the entire landscape in a thick layer of snow and a silence has \n" +
            "taken hold of the air. It feels as if you are in a dream; a sense of relief takes over as you realize \n" +
            "LAODICEA might be safe to venture into further...",

            //Goshen 
            "You are walking up to a desolate fortress. You're immediately met by a depressing city. In GOSHEN the air\n" +
            "is thick with smoke, obstructing your vision beyond a few meters. Each step you take is a burden on your \n" +
            "very being, this world is clearly not meant for you. Because of these horrible conditions you feel exposed\n" +
            "and in jeopardy. Far behind you you smell the pungent odors of creatures. Some have noticed you, and their\n " +
            "interest has peaked... ",

            //the land of Nod
            "As you get closer your eyes begin to burn for the light. The LAND OF NOD is ancient and to enter is to experience peace.\n" +
            "You find yourself face to face with enormous statues carved out of the mountains themselves. Carvings of beings you've \n" +
            "never seen before. This world seems too calm. Whether this is true or just appearances remains to be seen, but for now \n" +
            "you're hopeful. Despite the uncomfortable atmosphere you don't feel a sense of dread or danger...",

            //Jerash - tiny but mighty. Overcomers.
            "You have traversed through Jordan and have now entered JERASH. You're immediately met by a hostile world.\n" +
            "The air is dry and hot, bright light blinds you and you can feel your lungs burn with every breath. You \n" +
            "can't help but wonder who or what inhabits this world and you can't wait to find out. Who knows what secrets\n" +
            "this world holds, but not everything that's hidden may be as pleasant as this world...",
            }; //end string array

            return locations[new Random().Next(locations.Length)];

        } //end getlocation
    }// end class

}// end namespace
