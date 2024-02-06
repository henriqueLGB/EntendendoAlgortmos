using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> lista = new List<int> { 100,48,50,90,80,70,10};
            List<int> listaOrganizada = QuickSort(lista);

            Console.WriteLine(string.Join(",", listaOrganizada));
        }

        private static List<int> QuickSort(List<int> lista)
        {
            if (lista.Count() < 2) return lista;

            int pivo = lista[0];
            List<int> menores = lista.Skip(1).Where(x => x <= pivo).ToList();
            List<int> maiores = lista.Skip(1).Where(x => x > pivo).ToList();

            return QuickSort(menores).Concat(new List<int> { pivo }).Concat(QuickSort(maiores)).ToList();
        }

    }
}
