using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedGreedLibrary
{
    public class Satisfiers
    {
        Dictionary<string, NGSatisfier> satisfiers = new Dictionary<string, NGSatisfier>();

        public NGSatisfier Add(string key, NGSatisfier sat)
        {
            if(!satisfiers.ContainsKey(key))
                satisfiers.Add(key, sat);
            return sat;
        }

        public NGSatisfier Get(string key)
        {
            if (!satisfiers.ContainsKey(key))
                return satisfiers[key];
            return null;
        }

        public List<NGSatisfier> Get()
        {
            return satisfiers.Values.ToList();
        }
    }
}
