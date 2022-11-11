using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Worm : Animal
    {
        public Worm(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public bool GoodForFishing { get; set; } = true;
        public override string DoSound()
        {
            return "Worm noice";
        }
    }
}
