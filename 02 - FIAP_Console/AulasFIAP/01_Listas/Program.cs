using System.Collections;

namespace _01_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var valores = new List<int> { -5, -2, -1, -10, 0, 15, 1, 2, 8, 7 };

            List<int> filtro = valores.FindAll(element => element > 0);

            Console.WriteLine(string.Join(", ", filtro));
        }
    }
}