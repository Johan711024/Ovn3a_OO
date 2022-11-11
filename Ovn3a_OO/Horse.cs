using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Horse : Animal, IPerson
    {
        public bool Tamed { get; set; } = true;

        public Horse(string name, int age, int weight, bool tamed) : base(name, weight, age)
        {
            Tamed = tamed;
        }

        public override string DoSound()
        {
            return "Horsesound";
        }

        public override string Stats()
        {
            return $"{base.Stats()}Is tame: {Tamed}";
        }

        public void Talk()
        {
            Console.WriteLine("I'm a Centaur!");
        }
    }
}
