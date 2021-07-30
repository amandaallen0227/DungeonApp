using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Characters
    {
        public static void Header(string title)
        {
            Console.Title = "||||" + title + "||||";
            Console.WriteLine(title);
        } //end header
    } //end class
} //end namespace
