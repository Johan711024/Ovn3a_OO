using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Worm : Animal
    {
        public bool GoodForFishing { get; set; } = true;
        public override void DoSound()
        {
            Console.WriteLine("Worm noice");
        }
    }
}
