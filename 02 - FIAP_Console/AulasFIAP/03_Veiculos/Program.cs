using _03_Veiculos.Models;

namespace _03_Veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo v01 = new Veiculo();
            v01.ValorHora = 10.2;
            v01.ValorAdicional = 2.5;
            v01.Horas = 2;
            v01.DoTotal();

            Console.WriteLine(v01.DoViewCupom());

            Segurado s01 = new Segurado(20);
            s01.ValorHora = 10.2;
            s01.ValorAdicional = 2.5;
            s01.Horas = 2;
            s01.DoDesconto();
            s01.DoTotal();

            Console.WriteLine(s01.DoViewCupom());
        }
    }
}