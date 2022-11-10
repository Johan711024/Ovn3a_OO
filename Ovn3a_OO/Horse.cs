using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Horse : Animal
    {
        public bool Tamed { get; set; } = true;
        public override void DoSound()
        {
            throw new NotImplementedException();
        }
    }
}
