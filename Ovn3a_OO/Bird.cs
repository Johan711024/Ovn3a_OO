using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Bird : Animal
    {
        //Om samtliga fåglar behöver ett nytt attribut ska det läggas här
        

        public bool CanFly { get; set; } = true;
        

        public Bird(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public override string DoSound()
        {
            return "Birdsong";
        }
        public override string Stats()
        {
            base.Stats();
            return CanFly.ToString();
        }
        //return $"{base.Drive(distance)} From: {GetType().Name}";
    }
}
