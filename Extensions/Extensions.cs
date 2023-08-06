using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static int ToInt(this string value)
        {
            var result = int.TryParse(value, out int resultValue);
            return result? resultValue : 0;
        }
    }
}
