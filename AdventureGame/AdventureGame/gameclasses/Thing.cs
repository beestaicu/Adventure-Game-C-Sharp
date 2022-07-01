using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.gameclasses
{
    // ================================================================================
    // class Thing
    // Contains Treasure, Room, and Player essential object types of adventure game
    // ================================================================================
    [Serializable]
    public class Thing // the basic Thing from which all Adventure objects descend.
    {
        private string _name;
        private string _description;
        private bool _cantake;

        public Thing(string aName, string aDescription)
        {
            // standard constructor:
            _name = aName;
            _description = aDescription;
            _cantake = true; // sets _cantake to default value
        }
        public Thing(string aName, string aDescription, bool aCantake)
        {
            // alternative constructor
            _name=aName;
            _description=aDescription;
            _cantake = aCantake;
        }

        public string Name // Name property
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description // Description property
        {
            get { return _description; }
            set { _description = value; }
        }
        public bool Cantake // Cantake property
        {
            get { return _cantake; }
            set { _cantake = value; }
        }
        public virtual string Describe() // !! note this is a virtual method
        {
            return Name + " " + Description;
        }
    }
}
