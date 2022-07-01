using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public enum Dir
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

    public class Msg
    {
        public const string NOEXIT = "No Exit";

        private Msg()
        {
            // constructor is private so a msg object cannot be created using 'new'
        }
    }
}
