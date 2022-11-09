namespace Ovn3a_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new();

            try
            {
                person.Age = 0;
                person.fName = "";
                person.lName = null;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine($"KASTAR ARGUMENT UNDANTAG: {e.Message}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"KASTAR NULLREFERENS UNDANTAG: {e.Message}");
            }
            finally { Console.WriteLine($"KLART SLUT! "); }


            Console.WriteLine("Ovn3a");
        }
    }
}