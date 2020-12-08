using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class ReportRepair
    {
        public static int One(IEnumerable<int> numbers)
        {
            int numberTwoHelper = 0;

            return numbers.First(n => numbers.Any(n2 => n + (numberTwoHelper = n2) == 2020)) * numberTwoHelper;
        }

        public static int Two(IEnumerable<int> numbers)
        {
            int n2Help = 0;
            int n3Help = 0;

            return numbers.First(n => numbers.Any(n2 => numbers.Any(n3 => n + (n2Help = n2) + (n3Help = n3) == 2020))) * n2Help * n3Help;
        }
    }
}
