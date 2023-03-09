using _02_Temp.Models;

namespace _02_Temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temp = new Temperatura();

            Console.Write("Digite um Valor: ");
            double.TryParse(Console.ReadLine(), out temp.valor);

            Console.WriteLine($"Conversao da Temperatura em Celsius: {temp.Celsius()}");
            Console.WriteLine($"Conversao da Temperatura em Fahrenheit: {temp.Fahrenheit()}");
        }
    }
}