namespace ValorVenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            double valorVenda, calculoVenda = 0.0f;
            int formaVenda;

            do
            {
                Console.Write("Digite o Valor de Venda R$: ");
                double.TryParse(Console.ReadLine(), out valorVenda);
                Console.Write("Escolha forma Pagamento: [1] - A Vista / [2] - Debito / [3] - Cred. 3x (5%) / [4] - Cred. 4x+ (10%): ");
                int.TryParse(Console.ReadLine(), out formaVenda);

                switch (formaVenda)
                {
                    case 1:
                        calculoVenda = valorVenda - (valorVenda * 0.1);
                        break;
                    case 2:
                        calculoVenda = valorVenda;
                        break;
                    case 3:
                        calculoVenda = valorVenda + (valorVenda * 0.05);
                        break;
                    case 4:
                        calculoVenda = valorVenda + (valorVenda * 0.1);
                        break;
                    default:
                        Console.WriteLine("Valor informado nao existente!");
                        break;
                }
                Console.WriteLine($"Valor final da Compra R${Math.Round(calculoVenda, 2)}");

                Console.WriteLine("");
                Console.Write("Deseja Executar Novamente? [Y/N]: ");
                continuar = Console.ReadLine();
                Console.WriteLine("");

            } while (continuar.ToLower().Equals("y"));
        }
    }
}