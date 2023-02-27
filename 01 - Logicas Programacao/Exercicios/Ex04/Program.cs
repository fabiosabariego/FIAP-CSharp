namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Credito especial concedido pelo banco

            float saldoMedio;
            double credito;

            Console.Write("Digite o saldo medio de sua conta: R$");
            float.TryParse(Console.ReadLine(), out saldoMedio);

            Console.Write($"Saldo Medio da Conta: R${Math.Round(Convert.ToDouble(saldoMedio), 2)} < -- > ");

            if (saldoMedio >= 0.0 && saldoMedio <= 200.00)
            {
                credito = 0;
            }
            else if (saldoMedio >= 201.00 && saldoMedio <= 400.00)
            {
                credito = Convert.ToDouble(saldoMedio * 0.2);
            }
            else if (saldoMedio >= 401.00 && saldoMedio <= 600.00)
            {
                credito = Convert.ToDouble(saldoMedio * 0.3);
            }
            else
            {
                credito = Convert.ToDouble(saldoMedio * 0.4);
            }

            Console.WriteLine($"Credito liberado: R${Math.Round(credito, 2)}");
        }
    }
}