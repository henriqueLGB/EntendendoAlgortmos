using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaBinaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //LISTA NÚMERICA
            List<int> listaNumerica = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //RECEBENDO O RESULTADO DA PESQUISA
            int? resultado = PesquisaBinaria(listaNumerica, 8);

            //IMPRIMINDO
            Console.WriteLine(resultado);
        }

        public static int? PesquisaBinaria(List<int> lista, int item)
        {
            var baixo = 0;
            var alto = lista.Count() - 1;

            while(baixo <= alto)
            {
                var meio  = (baixo + alto) / 2;
                var chute = lista[meio];

                if (chute == item) return meio;

                if (chute > item)
                {
                    alto = meio - 1;
                }
                else
                {
                    baixo = meio + 1;
                }

            }

            return null;
        }

    }
}
