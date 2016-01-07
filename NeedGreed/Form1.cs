using NeedGreedLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGTest
{
    public partial class Form1 : Form
    {
        public List<Character> charactersList = new List<Character>();
        List<NGSatisfier> decsList = new List<NGSatisfier>();
        NeedGreed n;

        public Form1()
        {
            InitializeComponent();
            InitNeedGreed();
            InitForms();

        }

        private void add_char_Click(object sender, EventArgs e)
        {

        }

        public void InitNeedGreed()
        {
            n = new NeedGreed();

            n.createStat(new Hunger());
            n.createStat(new Fear());
            n.createStat(new Money());

            NGSatisfier food = new NGSatisfier("Food", new Dictionary<NGObject, float>() { { n.stats.Get("Hunger"), -0.5f }, { n.stats.Get("Money"), 0.3f } }, new Dictionary<NGObject,float>{{n.stats.Get("Money"), 0.3f}});
            NGSatisfier work = new NGSatisfier("Work", new Dictionary<NGObject, float>() { { n.stats.Get("Hunger"), 0.7f }, { n.stats.Get("Money"), -0.5f } }, new Dictionary<NGObject, float> { { n.stats.Get("Hunger"), 0.7f } });

            decsList = new List<NGSatisfier>() { food, work };
        }

        public void InitForms()
        {
            foreach(KeyValuePair<string, NGObject> o in n.stats.Get())
            {
                characters.Columns.Add(o.Key + "col", o.Key);
            }
        }

        private void cycle_butt_Click(object sender, EventArgs e)
        {
            foreach(Character c in charactersList)
            {
                var a = c.Decision(decsList);
                c.Apply(a);
            }
        }
    }

    public class Hunger : NGObject
    {
        public Hunger()
        {
            name = "Hunger";
            mask = 1;
            type = NGType.NEED;
        }
    }

    public class Fear : NGObject
    {
        public Fear()
        {
            name = "Fear";
            mask = 0.8f;
            type = NGType.NEED;
        }
    }

    public class Money : NGObject
    {
        public Money()
        {
            name = "Money";
            mask = 0.6f;
            type = NGType.GREED;
        }
    }
}
