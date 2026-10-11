using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program93
{
    internal class Program
    {
        static void Main()
        {
            bool result = (true ? (false ? 1 : 2) : (true ? 3 : 4)) == 2;
            Console.WriteLine(result); // True
        }
    }
}
