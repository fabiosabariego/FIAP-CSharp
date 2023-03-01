namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com Vetores (Array)
            double[] valorVendas = new double[5];
            double valorTotal = 0;

            for (int i = 0; i < valorVendas.Length; i++)
            {
                Console.Write($"Digite as vendas do vendedor {i + 1}: ");
                double.TryParse(Console.ReadLine(), out valorVendas[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");

            for (int i = 0;i < valorVendas.Length; i++)
            {
                Console.WriteLine($"O valor de Venda do Vendedor {i + 1} foi de R${valorVendas[i]}");
                valorTotal += valorVendas[i];
            }

            Console.WriteLine("");
            Console.WriteLine($"O valor total de Vendas foi de {valorTotal}");
        }
    }
}