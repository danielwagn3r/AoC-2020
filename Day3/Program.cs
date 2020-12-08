using System;
using System.IO;

namespace Day3
{
    public class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var input = await File.ReadAllLinesAsync("input.txt");
        }
    }
}
