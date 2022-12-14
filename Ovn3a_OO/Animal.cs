using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public abstract class Animal
    {
        //Om samtliga djur behöver nytt attribut ska det läggas här

        //public Animal() { }
        public Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public string Name { get; set; } = string.Empty;
        public int  Weight { get; set; }
        public int Age { get; set; }

        public abstract string DoSound();

        public virtual string Stats() 
        {        
            //return Name + Weight.ToString() + Age.ToString();
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}, ";
        }
        


    }
}
