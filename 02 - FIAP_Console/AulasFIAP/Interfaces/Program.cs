using Interfaces.Models;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alimentacao refeicoes = new Alimentacao();
            Transporte veiculos = new Transporte();
            Diaria diarias = new Diaria();
            GerenciadorDespesas gerenciador = new GerenciadorDespesas();


            //Populando refeicoes
            Console.WriteLine("ALIMENTACAO");
            refeicoes.NomeRestaurante = "Capixaba";
            refeicoes.CadastrarDespesas("Almoco");
            refeicoes.CalcularDespesas(10.10);
            refeicoes.ListarDespesas();
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

            //Populando Transportes
            Console.WriteLine("TRANSPORTE");
            veiculos.KmPercorrido = 150.40;
            veiculos.CalcularDespesas(58.22);
            veiculos.Descricao = "Viagem Cliente";
            veiculos.ListarDespesas();
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

            //Populando Diarias
            Console.WriteLine("DIARIAS");
            diarias.CalcularDespesas(5);
            diarias.Descricao = "Hotel Cliente";
            diarias.ListarDespesas();
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

            gerenciador.AnalisarDespesas(refeicoes);
            gerenciador.AnalisarDespesas(veiculos);
            gerenciador.AnalisarDespesas(diarias);

            Console.WriteLine($"Total dos Gastos: R${gerenciador.TotalDespesas}");
        }
    }
}