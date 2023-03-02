namespace CalcPesoAltura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            int sexo;
            double altura, peso;

            do
            {
                Console.Write("Digite [1] - Homen / [2] - Mulher: ");
                int.TryParse(Console.ReadLine(), out sexo);

                Console.Write("Digite a Altura: ");
                double.TryParse(Console.ReadLine(), out altura);

                switch (sexo)
                {
                    case 1:
                        peso = 72.2 * altura - 58;
                        Console.WriteLine($"O Peso ideal para Homem e: {peso}");
                        break;
                    
                    case 2:
                        peso = 62.1 * altura - 44.7;
                        Console.WriteLine($"O Peso ideal para Mulher e: {peso}");
                        break;

                    default:
                        Console.Write("Valor informado nao existente!");
                        break;
                }

                Console.WriteLine("");
                Console.Write("Deseja Calcular Novamente? [Y/N]: ");
                Console.WriteLine("");
                continuar = Console.ReadLine();

            } while (continuar.ToLower().Equals("y"));
        }
    }
}