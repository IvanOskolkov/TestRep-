using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");
        int[] chosenNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(lines[1]);
        string[] tickets = lines.Skip(2).ToArray();

        string[] results = new string[n];

        for (int i = 0; i < n; i++)
        {
            int[] ticketNumbers = tickets[i].Split(' ').Select(int.Parse).ToArray();
            results[i] = IsTicketWinning(chosenNumbers, ticketNumbers) ? "Lucky" : "Unlucky";
        }

        File.WriteAllLines("output.txt", results);
    }

    static bool IsTicketWinning(int[] chosenNumbers, int[] ticketNumbers)
    {
        int count = ticketNumbers.Count(x => chosenNumbers.Contains(x));
        return count >= 3;
    }
}