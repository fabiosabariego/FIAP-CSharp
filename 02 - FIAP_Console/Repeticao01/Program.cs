namespace Repeticao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabuada

            int num;
            int res;

            Console.Write("Digite numero para tabuada: ");
            int.TryParse(Console.ReadLine(), out num);

            for (int i = 1; i < 11; i++)
            {
                res = num * i;
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
            Console.WriteLine("Fim da Tabuada!!");

        }
    }
}