namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicao de desvio encadeado (ELSE IF)

            int idadePassageiro;

            Console.Write("Digite sua idade: ");
            int.TryParse(Console.ReadLine(), out idadePassageiro);

            if (idadePassageiro < 16)
            {
                Console.WriteLine("Voce nao pode votar, nem entrar na VAN!!");
            }
            else if (idadePassageiro >= 16 && idadePassageiro < 18)
            {
                Console.WriteLine("Caso queira, voce pode entrar na VAN e votar!");
            }
            else
            {
                Console.WriteLine("A votacao e Obrigatoria, entre na VAN");
            }

        }
    }
}