using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var input = (await File.ReadAllLinesAsync("input.txt")).Select(line => int.Parse(line));

            Console.WriteLine($"Puzzle 1: {ReportRepair.One(input)}");

            Console.WriteLine($"Puzzle 2: {ReportRepair.Two(input)}");
        }
    }
}
