namespace SomatoriaNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma = 0;

            Console.Write("Digite o primeiro Numero: ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write("Digite o segundo Numero: ");
            int.TryParse(Console.ReadLine(), out n2);

            for (int i = n1; i <= n2; i++)
            {
                soma += i;
            }

            Console.WriteLine($"A soma dos numeros entre {n1} e {n2} foi: {soma}");

        }
    }
}