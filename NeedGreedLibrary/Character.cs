using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedGreedLibrary
{
    public class Character
    {
        List<NGObject> stats;

        public Character(List<NGObject> objs)
        {
            stats = new List<NGObject>();
            stats.AddRange(objs);
        }

        public NGObject Consume(NGObject o, float val)
        {
            stats[stats.IndexOf(o)].value += val;
            return stats[stats.IndexOf(o)];
        }

        public NGSatisfier Decision(List<NGSatisfier> sats)
        {
            Dictionary<NGSatisfier, float> scores = new Dictionary<NGSatisfier, float>();
            foreach(NGSatisfier s in sats)
            {
                float score = 0;
                foreach(KeyValuePair<NGObject,float> o in s.influence)
                {
                    score += o.Value * stats[stats.IndexOf(o.Key)].value * stats[stats.IndexOf(o.Key)].mask;
                }

                scores.Add(s, score);
            }

            return scores.OrderBy(x => x.Value).First().Key;
        }

        public void Apply(NGSatisfier sat)
        {
            foreach(KeyValuePair<NGObject, float> i in sat.influence)
            {
                this[i.Key].value += i.Value;
            }
        }

        public NGObject this[NGObject obj]
        {
            get { return stats[stats.IndexOf(obj)]; }
            set { stats[stats.IndexOf(obj)] = value; }
        }
    }
}
