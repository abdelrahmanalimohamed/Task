using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>  list = new List<int>(1);

            list.Add(5);
            list.Add(6);

            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.Read();
        }
    }
}
