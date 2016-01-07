using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedGreedLibrary
{
    public class NeedGreed
    {
        public Objects stats;

        public NeedGreed()
        {
            stats = new Objects();
        }

        public Character createCharacter(string name)
        {
            return new Character(stats.Get(), name);
        }

        public NGObject createStat(NGObject obj)
        {
            return stats.Add(obj.name, obj);
        }

    }
}
