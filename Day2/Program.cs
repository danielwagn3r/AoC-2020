using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Day2
{
    public class Program
    {
        static async Task Main(string[] args)
        {


            var input = ParseInput((await File.ReadAllLinesAsync("input.txt")));

            Console.WriteLine($"Puzzle 1: {PasswordPhilosophy.One(input)}");
            Console.WriteLine($"Puzzle 2: {PasswordPhilosophy.Two(input)}");
        }

        public static IEnumerable<Entry> ParseInput(string[] lines)
        {
            char[] delimiters = { '-', ':', ' ' };

            return lines.Select(line => line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries))
                .Select(tokens => new Entry()
                {
                    From = int.Parse(tokens[0]),
                    To = int.Parse(tokens[1]),
                    Letter = tokens[2][0],
                    Password = tokens[3]
                });
        }
    }
}
