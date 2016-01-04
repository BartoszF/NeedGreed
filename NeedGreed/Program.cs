using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using NeedGreedLibrary;

namespace NGTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            NeedGreed n = new NeedGreed();

            n.createStat(new Hunger());
            n.createStat(new Fear());
            n.createStat(new Money());

            Character c = n.createCharacter();
            c.Consume(n.stats.Get("Hunger"),0.2f);
            c.Consume(n.stats.Get("Money"), 0.1f);

            NGSatisfier food = new NGSatisfier("Food", new Dictionary<NGObject, float>() { { n.stats.Get("Hunger"), -0.5f }, { n.stats.Get("Money"), 0.3f } });
            NGSatisfier work = new NGSatisfier("Work", new Dictionary<NGObject, float>() { { n.stats.Get("Hunger"), 0.7f }, {n.stats.Get("Money"), -0.5f} });

            List<NGSatisfier> decs = new List<NGSatisfier>() { food, work };

            while (true)
            {
                var a = c.Decision(decs);
                Console.WriteLine(a.name);
                c.Apply(a);
            }

        }
    }

    public class Hunger : NGObject
    {
        public Hunger()
        {
            name = "Hunger";
            mask = 2;
            type = NGType.NEED;
        }
    }

    public class Fear : NGObject
    {
        public Fear()
        {
            name = "Fear";
            mask = 1.5f;
            type = NGType.NEED;
        }
    }

    public class Money : NGObject
    {
        public Money()
        {
            name = "Money";
            mask = 0.8f;
            type = NGType.GREED;
        }
    }
}
