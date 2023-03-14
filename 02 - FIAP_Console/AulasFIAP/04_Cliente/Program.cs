using _04_Cliente.Models;

namespace _04_Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Fabio";
            cliente.Codigo = 12234;

            cliente.Print();
        }
    }
}