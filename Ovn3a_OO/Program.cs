namespace Ovn3a_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());

            foreach(UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
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