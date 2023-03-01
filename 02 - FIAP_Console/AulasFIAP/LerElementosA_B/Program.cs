using System.Runtime.Serialization.Formatters;

namespace LerElementosA_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorA = new int[5];
            int[] vetorB = new int[vetorA.Length];

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write($"Digite o valor {i + 1}: ");
                int.TryParse(Console.ReadLine(), out vetorA[i]);
            }

            for (int i = 0; i < vetorB.Length; i++)
            {
                vetorB[(vetorB.Length - 1) - i] = vetorA[i];
                Console.WriteLine($"vetorB[{(vetorB.Length - 1) - i}] = {vetorB[(vetorB.Length - 1) - i]} - Recebendo vetorA[{i}] = {vetorA[i]}");
            }

            //Para fazermos esta logica, podemos usar a seguinte funcao: vetorB = Array.Reverse(vetorA);

        }
    }
}