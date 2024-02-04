namespace OrdenacaoSelecao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> arr = new List<int> { 64, 25, 12, 22, 11 };
  
            foreach(int num in OrdenacaoPorSelecao(arr))
            {
                Console.Write(num + " ");
            }

        }

        private static int BuscaMenor(List<int> arr)
        {
            int menor = arr[0];
            int menorIndice = 0;

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < menor)
                {
                    menor = arr[i];
                    menorIndice = i;
                }
            }

            return menorIndice;

        }

        private static List<int> OrdenacaoPorSelecao(List<int> arr)
        {
            List<int> novoArr = new List<int>();

            while (arr.Count > 0)
            {
                int menor = BuscaMenor(arr);
                novoArr.Add(arr[menor]);
                arr.RemoveAt(menor);
            }

            return novoArr;
        }
    }
}
