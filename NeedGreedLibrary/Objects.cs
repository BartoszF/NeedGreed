using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedGreedLibrary
{
    public class Objects
    {
        Dictionary<string, NGObject> objects = new Dictionary<string, NGObject>();

        public NGObject Add(string key, NGObject sat)
        {
            if (!objects.ContainsKey(key))
                objects.Add(key, sat);
            return sat;
        }

        public NGObject Get(string key)
        {
            if (objects.ContainsKey(key))
                return objects[key];
            return null;
        }

        public List<NGObject> Get()
        {
            return objects.Values.ToList();
        }
    }
}
