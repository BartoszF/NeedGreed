using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedGreedLibrary
{
    public enum NGType
    {
        GREED,
        NEED
    };

    public class NGObject
    {
        public string name;
        public float value;
        public float mask;
        public NGType type;

        public Action<Character> OnSatisfy;
        public Action<Character> OnIgnore;
    }
}
