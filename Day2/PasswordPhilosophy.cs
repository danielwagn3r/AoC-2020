using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public static class PasswordPhilosophy
    {
        public static int One(IEnumerable<Entry> input)
        {
            int letterCount = 0;

            return input.Count(e => (letterCount = e.Password.Count(c => c == e.Letter)) >= e.From && letterCount <= e.To);
        }

        public static int Two(IEnumerable<Entry> input)
        {
            return input.Count(e => e.Password[e.To-1].Equals(e.Letter) ^ e.Password[e.From - 1].Equals(e.Letter));
        }
    }
}
