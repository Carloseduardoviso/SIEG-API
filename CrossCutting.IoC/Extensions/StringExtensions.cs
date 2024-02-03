using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.IoC.Extensions
{
    public static class StringExtensions
    {
        public static string ConcatenarStrings(this IEnumerable<string> strings) => string.Join(" - ", strings);
    }
}
