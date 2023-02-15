namespace A03_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalCompras;
            string cupom;

            Console.Write("Digite o total de compras: R$");
            double.TryParse(Console.ReadLine(), out totalCompras);

            Console.Write("insira seu cupom caso tenha: ");
            cupom = Console.ReadLine();

            if( totalCompras > 1000 || cupom == "DESCONTO20")
            {
                totalCompras = Math.Round(Convert.ToDouble(totalCompras - (totalCompras * 0.2)), 2);
                Console.WriteLine($"O valor da compra com desconto foi de R${totalCompras}");
            }
            else
            {
                Console.WriteLine($"Descontos nao foram aplicados, sua compra foi de R${Math.Round(Convert.ToDouble(totalCompras), 2)}");
            }
           
        }
    }
}