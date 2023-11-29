using System.Diagnostics;
using Microsoft.Win32.SafeHandles;

namespace advent_3;
class Program
{
    static void Main(string[] args)
    {
        string[] numbers = File.ReadAllText("input.txt").Split("\n");
        List<string> oxygenrating = numbers.ToList();
        List<string> carbonrating = numbers.ToList();

        string gamma = "";
        string epsilon = "";
        string o2result = "";
        string carbonresult = "";

        for (int i = 0; i < numbers[0].Length; i++)
        {
            // gamma / epslion checks
            int zeroes = 0;
            foreach (string number in numbers) { if (number[i] == '0') { zeroes++; } }
            if (zeroes > numbers.Length / 2) { gamma += "0"; epsilon += "1"; }
            else { gamma += "1"; epsilon += "0"; }

            // oxygen checks
            int o2zeroes = 0;
            char removechar = '0';
            if (oxygenrating.Count == 1) { o2result = oxygenrating[0]; }
            else
            {
                List<string> tempo2 = oxygenrating.ToList();
                foreach (string number in oxygenrating) { if (number[i] == '0') { o2zeroes++; } }
                if (o2zeroes > oxygenrating.Count / 2) { removechar = '1'; }
                foreach (string number in oxygenrating) { if (number[i] == removechar) { tempo2.Remove(number); } }
                oxygenrating = tempo2.ToList();
            }
            if (oxygenrating.Count == 1) { o2result = oxygenrating[0]; }

            // carbon checks
            int carbonzeroes = 0;
            char removecarbonchar = '0';
            if (carbonrating.Count == 1) { carbonresult = carbonrating[0]; }
            else
            {
                List<string> tempcarbon = carbonrating.ToList();
                foreach (string number in carbonrating) { if (number[i] == '0') { carbonzeroes++; } }
                if (carbonzeroes <= carbonrating.Count / 2) { removecarbonchar = '1'; }
                foreach (string number in carbonrating) { if (number[i] == removecarbonchar) { tempcarbon.Remove(number); } }
                carbonrating = tempcarbon.ToList();
            }
            if (carbonrating.Count == 1) { carbonresult = carbonrating[0]; }
        }

        Console.WriteLine("gamma: " + gamma);
        Console.WriteLine("epsilon: " + epsilon);

        Console.WriteLine("Power consumption: " + Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2));

        Console.WriteLine("Oxygen: " + o2result);
        Console.WriteLine("Carbon: " + carbonresult);

        Console.WriteLine("Life Support: " + Convert.ToInt32(o2result, 2) * Convert.ToInt32(carbonresult, 2));
    }
}
