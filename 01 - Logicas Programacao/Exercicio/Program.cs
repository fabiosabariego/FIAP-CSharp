namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valorDoado;
            double investimento;

            Console.Write("Digite o valor a ser doado: R$");
            float.TryParse(Console.ReadLine(), out valorDoado);

            if (valorDoado >= 1000.00)
            {
                investimento = valorDoado * 0.15;
            }
            else
            {
                investimento = valorDoado * 0.05;
            }

            Console.WriteLine($"O valor doado foi de R${Convert.ToDouble(Math.Round(investimento,2))}");

        }
    }
}