using System;

namespace Ovn3a_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            Animals.Add(new Bird("Fågel", 3, 3));
            Animals.Add(new Wolf("Varg", 4,4));
            Animals.Add(new Flamingo("Flamingo",5,5));
            Animals.Add(new WolfMan("Wolverine", 200, 200));
            Animals.Add(new Dog("Kiwi", 5, 8, true));

            Console.WriteLine($"Antal djur: {Animals.Count}");
            foreach(Animal a in Animals)
            {
                Console.WriteLine($"{a.Stats()}, Type: {a.GetType().Name}, Ljud: {a.DoSound()}");
                if (a is IPerson)
                {
                    var temp = a as IPerson; //Här sker typecasting, då kommer vi åt medlemar i IPerson
                    temp?.Talk();
                    
                }
                
                if(a is Dog)
                {
                    var temp = a as Dog;
                    Console.WriteLine(temp?.DoTrick());
                    var temp2 = (Dog)a;    // Alternativ syntax för att casta
                    Console.WriteLine(temp2.DoTrick());
                }

            }

            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());

            foreach(UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            List<Dog> dogs = new List<Dog>();

            dogs.Add(new Dog("Fido", 10, 4, false));
            dogs.Add(new Dog("Lova", 15, 5, true));

            //dogs.Add(new Horse("svarten", 13, 500, true));

            // Svar 9: En häst är inte en hund
            // Svar 10: De behöver alla vara Animal

            Console.WriteLine("SKRIVER ALLA STATS()");
            foreach (Animal a in Animals)
            {
                Console.WriteLine(a.Stats());

            }

            // Svar 13: Osäker...Bird har egen Stats()...Det har inte t ex Wolf eller Dog...Bird skriver endast ut sin egen stat()..

            //Svar 15-18 

            Console.WriteLine("SKRIVER ALLA STATS() FÖR ENBART HUNDAR");
            foreach (Animal a in Animals)
            {
                //a.nyMetod(); kommer ej åt Dog specifikt
                if (a is Dog)
                {
                    Console.WriteLine(a.Stats());

                    var temp = a as Dog;
                    //temp.nyMetod(); kommer åt när jag castar

                }

            }

            //Person person = new();
            //try
            //{
            //    person.Age = 0;
            //    person.fName = "kllkl";
            //    person.lName = "lklkl";
            //}
            //catch(ArgumentException e)
            //{
            //    Console.WriteLine($"kastar argument undantag: {e.Message}");
            //}

            Console.WriteLine("Ovn3a");
        }
    }
}