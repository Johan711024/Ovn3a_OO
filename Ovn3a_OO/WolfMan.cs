using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class WolfMan : Wolf, IPerson
    {
        public WolfMan(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public void Talk()
        {
            Console.WriteLine("I am Wolfman");
        }
    }
}
