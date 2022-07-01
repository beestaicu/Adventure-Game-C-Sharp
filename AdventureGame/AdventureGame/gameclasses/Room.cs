using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.gameclasses
{
    /// <summary>
    /// Class Room
    /// </summary>
    [Serializable]

    public class Room: ThingHolder
    {
        private int _n, _s, _w, _e;

        // Contructor
        public Room(string aName, string aDescription,
            int aN, int aS, int aW, int aE, ThingList tl)
            : base(aName, aDescription, tl)
        {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }

        public int N
        {
            set { _n = value; }
            get { return _n; }
        }
        public int S
        {
            set { _s = value; }
            get { return _s; }
        }
        public int W
        {
            set { _w = value; }
            get { return _w; }
        }
        public int E
        {
            set { _e = value; }
            get { return _e;}   
        }
         
        public void SetDirs(int aN, int aS, int aW, int aE)
        {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }

        public void GetDirs(out int aN,out int aS, out int aW, out int aE) 
            // is out here variable reference not value
            // remind: out: can just call functions without assign value, must assign in method
            // remind: ref: must assign value to argument before call function, can not assign in method
        {
            aN = _n;
            aS = _s;
            aW = _w;
            aE = _e;
        }
        public override string Describe()
        {
            return String.Format("Name: {0}, Description {1}.", Name, Description)
                + "\r\nThings here: " + this.Things.Describe();
        }
    } // Room
} 

