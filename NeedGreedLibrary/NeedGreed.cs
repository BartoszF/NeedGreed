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

        public Character createCharacter()
        {
            return new Character(stats.Get());
        }

        public NGObject createStat(NGObject obj)
        {
            return stats.Add(obj.name, obj);
        }
    }
}
