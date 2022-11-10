using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Dog : Animal
    {
        public bool Bark { get; set; } = false;
        public override void DoSound()
        {
            throw new NotImplementedException();
        }
    }
}
