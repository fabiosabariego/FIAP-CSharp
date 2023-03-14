using _03_Investimento.Models;

namespace _03_Investimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Investimento inv = new Investimento();

            Console.Write("Dgite o Valor: R$");
            inv.Valor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Selecione Poupanca ou Renda Fixa [P / R]: ");
            inv.Tipo = Console.ReadLine().ToLower();


            Console.WriteLine($"Valor: R${Math.Round(inv.Valor, 2)} Corrigido: {Math.Round(inv.Correcao(), 2)}");

        }
    }
}