namespace advent_1;
class Program
{
    static void Main(string[] args)
    {
        List<int> depths = File.ReadAllText("input.txt").Split("\n").Select(int.Parse).ToList();

        int increasedCount = 0;

        for (int i = 0; i < depths.Count; i++)
        {
            Console.Write(depths[i]);
            if (i == 0)
            {
                Console.WriteLine(" - no previous measurement");
            }
            else if (depths[i] > depths[i - 1])
            {
                increasedCount++;
                Console.WriteLine(" - increased");
            }
            else
            {
                Console.WriteLine(" - decreased");
            }
        }

        Console.WriteLine("amount of increases: " + increasedCount);
    }
}
