using _02_AppSeguro.Models;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

namespace _02_AppSeguro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorAuto;
            Pessoa pessoas = new Pessoa();

            Console.Write("Informe o valor do veiculo: ");
            valorAuto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe sua Idade: ");
            pessoas.Idade = Convert.ToInt16(Console.ReadLine());

            Console.Write("Informe seu Sexo [M/F]: ");
            pessoas.Sexo = Console.ReadLine().ToUpper();

            Seguro seguro = new Seguro(pessoas, valorAuto);

            Console.WriteLine($"O valor do seguro: {seguro.CalcularSeguro()}");
        }
    }
}