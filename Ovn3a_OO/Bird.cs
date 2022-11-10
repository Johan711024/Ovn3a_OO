using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Bird : Animal
    {
        public bool CanFly { get; set; } = true;
        public override void DoSound()
        {
            Console.WriteLine("Birdsong");
        }
    }
}
