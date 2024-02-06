using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaComRecursao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Fat(5));
        }

        private static int Fat(int x)
        {
            if(x == 1)
            {
                return 1;
            }
            else
            {
                return x * Fat(x - 1);
            }
        }

    }
}
