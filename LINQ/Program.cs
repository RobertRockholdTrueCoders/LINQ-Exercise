namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baseball team names:");
            var baseballNames = new List<string>() { "Rockies", "Reds", "Angels", "Twins" };
            
            var lengthOfName = baseballNames.OrderByDescending(x => x.Length);
            foreach (var name in lengthOfName)
            {
                Console.WriteLine(name);
            }
        }
    }
}
