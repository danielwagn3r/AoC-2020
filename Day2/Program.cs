using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            char[] delimiters = { '-', ':', ' ' };

            var input = (await File.ReadAllLinesAsync("input.txt"))
                .Select(line => line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries))
                .Select(tokens => new Entry()
                {
                    From = int.Parse(tokens[0]),
                    To = int.Parse(tokens[1]),
                    Letter = tokens[2][0],
                    Password = tokens[3]
                });

            Console.WriteLine($"Puzzle 1: {PasswordPhilosophy.One(input)}");
        }
    }
}
