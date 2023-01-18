using System.Collections.Immutable;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gameNames = new List<string>() { "COD", "NBA 2k", "Fortnite", "Madden", "GTA", "Mortal Kombat" };

           var names = gameNames.OrderBy(x => x.Length);

            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
