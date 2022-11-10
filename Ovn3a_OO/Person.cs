using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                        age = value;
                }
                else
                {                  
                        throw new ArgumentNullException("Måste vara 1 år eller äldre");                   
                }
 
                
            }
        }
           
        private string? fname;
        public string? fName { get { return fname; }
            set {
                

                if (value?.Length >= 2 && value.Length <= 10)
                {
                    fname = value;
                }
                else
                {
                    throw new ArgumentNullException("Mellan 2 -10 tecken är tillåtet");
                }
            }
        }
        private string? lname;
        public string? lName
        {
            get { return lname; }
            set
            {


                if (value?.Length >= 3 && value.Length <= 15)
                {
                    lname = value;
                }
                else
                {
                    throw new ArgumentNullException("Mellan 3-15 tecken är tillåtet");
                }
            }
        }



        

        public double height { get; set; }

        public double weight { get; set; }


    }
}
