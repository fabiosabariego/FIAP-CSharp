namespace CalcBaseExpoente
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SolValores();
        }

        public static void SolValores()
        {
            double[] dados = new double[2];
            Console.Write("Digite o Valor da base: ");
            double.TryParse(Console.ReadLine(), out dados[0]);

            Console.Write("Digite o Valor do expoente: ");
            double.TryParse(Console.ReadLine(), out dados[1]);

            CalcExp(dados[0], dados[1]);
        }

        public static void CalcExp(double baseVal, double exp)
        {
            double resCalc = 1;
            for (int i = 1; i <= exp; i++)
            {
                resCalc *= baseVal;
            }
            Console.WriteLine($"O calculo de {baseVal}^{exp} = {resCalc} ");
        }
    }
}