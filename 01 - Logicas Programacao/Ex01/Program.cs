namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Converter um valor recebido em dolar para real
            float dolar;
            float real;

            // Dolar 5,34
            Console.Write("Digite o valor em dolar: U$");
            float.TryParse(Console.ReadLine(), out dolar);

            real = (dolar * 5.34f);

            Console.WriteLine($"Valor em dolar: U${dolar} convertido em Reais: R${Math.Round(real, 2)}");
            
        }
    }
}