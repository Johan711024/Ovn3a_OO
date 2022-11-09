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

                //  length = value < 0 ? 0 : value;

                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Ålder måste vara över 0");
                }
            }
        }
           
        private string fname;
        public string? fName { get { return fname; }
            set {
                

                if (value.Length >= 2 && value.Length <= 10)
                {
                    fname = value;
                }
                else
                {
                    Console.WriteLine("Mellan 2-10 tecken är tillåtet");
                }
            }
        }
        private string lname;
        public string? lName
        {
            get { return lname; }
            set
            {


                if (value.Length >= 3 && value.Length <= 15)
                {
                    lname = value;
                }
                else
                {
                    Console.WriteLine("Mellan 3-15 tecken är tillåtet");
                }
            }
        }



        

        public double height { get; set; }

        public double width { get; set; }


    }
}
