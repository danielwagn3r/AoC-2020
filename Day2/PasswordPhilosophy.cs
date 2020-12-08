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
            throw new NotImplementedException();
        }
    }
}
