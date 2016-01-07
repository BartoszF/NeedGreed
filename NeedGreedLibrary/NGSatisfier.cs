using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedGreedLibrary
{
    public class NGSatisfier
    {
        public string name;
        public Dictionary<NGObject, float> influence;
        public Dictionary<NGObject, float> needed;

        public NGSatisfier(string name, Dictionary<NGObject, float> inf, Dictionary<NGObject, float> needed)
        {
            this.name = name;
            this.influence = inf;
            this.needed = needed;
        }
    }
}
