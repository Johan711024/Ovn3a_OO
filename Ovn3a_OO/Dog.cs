using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Dog : Animal
    {

        public Dog(string name, int weight, int age, bool bark) : base(name, weight, age)
        {
            Bark = bark;
        }
        public bool Bark { get; set; } = false;
        
        public override string DoSound()
        {
            return "Dogbark";
        }

        public string DoTrick()
        {
            return "*Rolls over*";
        }

        public void nyMetod()
        {
            Console.WriteLine("ny metod i Dog");
        }


    }
}
