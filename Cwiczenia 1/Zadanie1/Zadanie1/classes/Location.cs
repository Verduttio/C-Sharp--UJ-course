using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.classes
{
    class Location
    {
        String _name;
        NonPlayerCharacter[] _npcList;
        bool _isUnlocked;

        public Location(String name, NonPlayerCharacter[] npcList, bool isUnlocked)
        {
            this._name = name;
            this._npcList = npcList;
            this._isUnlocked = isUnlocked;
        }

        public String Name
        {
            get { return _name; }
        }

        public NonPlayerCharacter[] NpcList
        {
            get { return _npcList; }
        }

        public bool IsUnlocked
        {
            get { return _isUnlocked; }
        }

    }
}
