using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedGreedLibrary
{
    public class Character
    {
        Dictionary<string, NGObject> stats;
        public string name;

        public Character(Dictionary<string, NGObject> objs, string name)
        {
            stats = new Dictionary<string, NGObject>();
            foreach(KeyValuePair<string, NGObject> kp in objs)
            {
                stats.Add(kp.Key, (NGObject)Activator.CreateInstance(kp.Value.GetType()));
            }

            this.name = name;
        }

        public NGObject Consume(NGObject o, float val)
        {
            stats[o.name].value += val;
            return stats[o.name];
        }

        public NGSatisfier Decision(List<NGSatisfier> sats)
        {
            Dictionary<NGSatisfier, float> scores = new Dictionary<NGSatisfier, float>();
            foreach(NGSatisfier s in sats)
            {
                float score = 0;
                int can = Can(s) ? 0 : 100;
                foreach(KeyValuePair<NGObject,float> o in s.influence)
                {
                    score += o.Value * stats[o.Key.name].value * stats[o.Key.name].mask + can;
                }

                scores.Add(s, score);
            }

            return scores.OrderBy(x => x.Value).First().Key;
        }

        public bool Can(NGSatisfier sat)
        {
            foreach (KeyValuePair<NGObject, float> o in sat.needed)
            {
                if (o.Value < this[o.Key].value) return false;
            }
            return true;
        }
        public void Apply(NGSatisfier sat)
        {
            foreach(KeyValuePair<NGObject, float> i in sat.influence)
            {
                this.Consume(i.Key,i.Value);
            }
        }

        public NGObject this[NGObject obj]
        {
            get { return stats[obj.name]; }
            set { stats[obj.name] = value; }
        }

        public NGObject this[string obj]
        {
            get { return stats[obj]; }
            set { stats[obj] = value; }
        }
    }
}
