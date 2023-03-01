namespace Matriz2x2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2, 2];
            int somaValores = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Digite o valor da posicao [{i}, {j}]: ");
                    int.TryParse(Console.ReadLine(), out matriz[i, j]);

                    somaValores += matriz[i, j];
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"O valor da Soma de todas as posicoes da matriz e: {somaValores}");
        }
    }
}