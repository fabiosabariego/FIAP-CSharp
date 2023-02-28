namespace NumPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, contaPar = 0;

            Console.Write("Digite o primeiro Numero: ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write("Digite o segundo Numero: ");
            int.TryParse(Console.ReadLine(), out n2);

            if(n1 > n2)
            {
                int aux = n1;
                n1 = n2;
                n2 = aux;
            }

            do
            {
                if(n1 % 2 == 0)
                {
                    contaPar++;
                }
                n1++;

            } while (n1 <= n2);


            Console.WriteLine($"A quantidade contada de numeros pares foi: {contaPar}");
        }
    }
}