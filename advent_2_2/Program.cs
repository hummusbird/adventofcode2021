namespace advent_2_2;
class Program
{
    static void Main(string[] args)
    {
        string[] inputs = File.ReadAllText("input.txt").Split("\n");

        int depth = 0;
        int horiz = 0;
        int aim = 0;

        foreach (string input in inputs)
        {
            int distance = int.Parse(input.Split(' ')[1]);

            if (input.StartsWith("forward"))
            {
                horiz += distance;
                depth += aim * distance;
            }
            else if (input.StartsWith("down"))
            {
                aim += distance;
            }
            else if (input.StartsWith("up"))
            {
                aim -= distance;
            }
        }

        Console.WriteLine("Final distance = " + depth * horiz);
    }
}
