using _02_AppSeguro.Models;

namespace _02_AppSeguro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seguro seguro = new Seguro();

            Console.Write("Informe sua Idade: ");
            seguro.Pessoas.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe seu Sexo [M/F]: ");
            seguro.Pessoas.Sexo = Console.ReadLine().ToUpper();

            Console.WriteLine($"O valor do seguro: {seguro.CalcularSeguro()}");
        }
    }
}