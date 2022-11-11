using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Swan : Bird
    {
        public Swan(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public int NoOfKids { get; set; }
    }
}
