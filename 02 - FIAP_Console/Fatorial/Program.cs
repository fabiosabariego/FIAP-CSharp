namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fatorial = 1;
            string opcao;

                Console.Write("Digite um numero: ");
                int.TryParse(Console.ReadLine(), out num);

                Console.Write($"{num}! = ");

                while (num >= 1)
                {
                    fatorial *= num;
                    num--;
                }
                Console.WriteLine(fatorial);
        }

            
    }
}