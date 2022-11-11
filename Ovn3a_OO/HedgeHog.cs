using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class HedgeHog : Animal
    {
        public HedgeHog(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public int NoOfSpikes { get; set; }
        public override string DoSound()
        {
            return "Hedgehog milklap";
        }
    }
}
