namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int filhos = (int) 3.0; // Casting
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine($"Caramba, voce tem {filhos} filhos?");
            //Console.WriteLine("");

            int n1, n2, res;
            float resFloat;

            Console.Write("Digite numero 01: ");
            //int.TryParse(Console.ReadLine(), out n1);     Esta e uma opcao para fazer a conversao
            n1 = Convert.ToInt16(Console.ReadLine());       // Esta e uma outra forma de fazer a convesao

            Console.Write("Digite numero 02: ");
            int.TryParse(Console.ReadLine(), out n2);

            Console.WriteLine($"{n1} + {n2} = {res = n1 + n2}");
            Console.WriteLine($"{n1} - {n2} = {res = n1 - n2}");
            Console.WriteLine($"{n1} * {n2} = {res = n1 * n2}");
            Console.WriteLine($"{n1} / {n2} = {resFloat = (float)n1 / n2}");

        }
    }
}