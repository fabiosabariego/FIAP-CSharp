namespace SolReajusteReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste;

            Console.Write("Digite seu Salario: R$");
            double.TryParse(Console.ReadLine(), out salario);

            Console.Write("Digite o Reajuste em %: ");
            double.TryParse(Console.ReadLine(), out reajuste);

            Console.WriteLine($"O Salario com reajuste de {reajuste}% e de R${Math.Round(CalcReajuste(reajuste, salario), 2)}");

        }

        public static double CalcReajuste(double reajuste, double salario)
        {
            return salario * ((reajuste / 100) + 1.0);
        }
    }
}