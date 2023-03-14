using _02___Conta.Models;

namespace _02___Conta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta cc = new Conta();
            cc.setSaldo(1000);
            Console.WriteLine($"O saldo e: {cc.getSaldo()}");
        }
    }
}