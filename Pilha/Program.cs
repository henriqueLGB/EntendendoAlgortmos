using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sauda("Henrique");
        }


        private static void Sauda(string nome)
        {
            Console.WriteLine("Olá, " + nome + " !");
            Sauda2(nome);
            Console.WriteLine("Preparado para dizer tchau....");
            Tchau();
        }

        private static void Sauda2(string nome)
        {
            Console.WriteLine("Como vai  " + nome + " ?");
        }

        private static void Tchau()
        {
            Console.WriteLine("Ok, tchau !");
        }

    }
}
