namespace advent_4;
class Program
{
    static void Main(string[] args)
    {
        string puzzleInput = File.ReadAllText("input.txt");

        List<int> numbers = puzzleInput.Split("\n")[0].Split(",").Select(int.Parse).ToList();
        List<string> stringboards = puzzleInput.Split("\n\n").ToList();
        stringboards.RemoveAt(0);
        List<List<List<int>>> boards = puzzleInput.Split("\n\n").ToList(); // split into boards
                                                                           // drop first item, the numbers
        for (int i = 1; i < puzzleInput.Count(); i++)
        {

        }
    }
}
