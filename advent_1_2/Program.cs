namespace advent_2;
class Program
{
    static void Main(string[] args)
    {
        List<int> depths = File.ReadAllText("input.txt").Split("\n").Select(int.Parse).ToList();

        int increasedCount = 0;

        for (int i = 0; i < depths.Count - 3; i++)
        {
            if (addthree(i, depths) < addthree(i + 1, depths))
            {
                increasedCount++;
            }
        }
        Console.WriteLine("number of increases: " + increasedCount);
    }

    static int addthree(int index, List<int> depths)
    {
        int value = 0;
        for (int i = 0; i < 3; i++)
        {
            value += depths[index + i];
        }
        return value;
    }
}
