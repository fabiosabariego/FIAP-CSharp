using _01_Polimorfismo.Models;
using System.Diagnostics;

namespace _01_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corrente ccFabio = new Corrente();
            ccFabio.Creditar(1500.00);
            ccFabio.Limite = 500.00;
            Console.WriteLine($"Saldo apos Deposito: {ccFabio.ConsultarSaldo()}");

            Console.WriteLine($"{ccFabio.Debitar(400.00)}");

            Console.WriteLine($" {ccFabio.Debitar(1220.30)}");

        }
    }
}