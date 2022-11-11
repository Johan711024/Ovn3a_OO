using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Wolf : Animal
    {
        public Wolf(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public bool ScaredOfHumans { get; set; } = true;
        public override string DoSound()
        {
            return "Wolf howling";
        }
    }
}
