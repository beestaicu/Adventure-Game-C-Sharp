using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.gameclasses
{
    [Serializable]
    public class Actor : ThingHolder
    {
        private Room _room;  // Room where Person is at present

        // constructor
        public Actor(string aName, string aDescription, Room aRoom, ThingList tl): 
            base(aName, aDescription, tl)
        {
            _room = aRoom;
        }

        // property
        public Room CurrentRoom 
        {
            get { return _room; }
            set { _room = value; }
        }

        // Describe method
        public override string Describe()
        {
            return String.Format("Name:{0}, Description {1}", Name, Description) +
                "\r\nCurrently in this room: " + this.CurrentRoom.Describe();
        }

    } // Actor
}
