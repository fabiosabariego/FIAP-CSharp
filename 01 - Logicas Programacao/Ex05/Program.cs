namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;
            double calcDesconto;

            Console.Write("Digite seu Salario: R$");
            float.TryParse(Console.ReadLine(), out salario);

            calcDesconto = salario * 0.11;

            if (calcDesconto >= 720.00)
            {
                calcDesconto = 720.00;
            }

            Console.WriteLine($"Com o Salario de R${Math.Round(Convert.ToDouble(salario), 2)} temos o desconto de R${Math.Round(Convert.ToDouble(calcDesconto), 2)}");

        }
    }
}