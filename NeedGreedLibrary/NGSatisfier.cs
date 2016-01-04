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

        public NGSatisfier(string name, Dictionary<NGObject, float> inf)
        {
            this.name = name;
            this.influence = inf;
        }
    }
}
