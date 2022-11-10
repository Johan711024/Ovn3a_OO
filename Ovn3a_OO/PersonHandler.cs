using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class PersonHandler
    {
        

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;

        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person pers = new Person();
            pers.Age=age;
            pers.fName=fname;
            pers.lName=lname;   
            pers.height=height; 
            pers.weight=weight;

            return pers;

            
        }
    }
}
