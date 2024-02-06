using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Regressiva(10);
        }

        private static void Regressiva(int i)
        {
            Console.WriteLine(i);

            if (i <= 1)
            {
                return;
            }
            else
            {
                Regressiva(i - 1);
            }
        }

    }
}
