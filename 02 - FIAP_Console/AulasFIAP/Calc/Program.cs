namespace Calc
{
    internal class Program
    {
        public static double n1, n2;

        static void Main(string[] args)
        {
            double res = 0;
            int opcao;

            entradaDados();
            exibeMenu();

            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    res = n1 + n2;
                    break;
                case 2:
                    res = n1 - n2;
                    break;
                case 3:
                    res = n1 * n2;
                    break;
                case 4:
                    if (n2 != 0)
                    {
                        res = n1 / n2;
                    }
                    else
                    {
                        Console.WriteLine("Impossível dividir por zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }

            exibirResultados(res);

        }

        public static void exibeMenu()
        {
            Console.Write("Agora, selecione a operação:\n\n" +
                "1 - Adição\n" +
                "2 - Subtração\n" +
                "3 - Multiplicação\n" +
                "4 - Divisão: ");
        }

        public static void exibirResultados(double result)
        {
            Console.WriteLine($"O resultado foi: {result}");
        }

        public static void entradaDados()
        {
            Console.WriteLine("Minha Super Calculadora\n");
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o primeiro número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
        }
    }
}