namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notas = new int[3,2];
            int qtdPares = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.Write($"Digite a Nota referente a posicao [{i}, {j}]: ");
                    int.TryParse(Console.ReadLine(), out notas[i,j]);
                }
            }

            //Mostra na Tela apenas os Numeros pares:
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (notas[i,j] % 2 == 0)
                    {
                        //Console.WriteLine($"Valor {notas[i,j]} e par!!");
                        qtdPares++;
                    }
                }
            }

            Console.WriteLine($"Quantidade de numeros pares digitados: {qtdPares}");

        }
    }
}