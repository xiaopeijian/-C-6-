using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBasicConsoleIO
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Basic Console I/O");
            GetUserDataClass g = new GetUserDataClass();
            string s = g.UserName;
            g.FormatNumericalData();
            Console.WriteLine(g.UserName);
            Console.ReadLine();
        }
    }
}
