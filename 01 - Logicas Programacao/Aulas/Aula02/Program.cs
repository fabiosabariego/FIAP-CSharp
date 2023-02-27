using System.Xml;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores Relacionais e condicoes (IF)

            int idade;

            Console.Write("Digite sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);

            if (idade > 12)
            {
                Console.WriteLine("Voce pode jogar!!");
            }
            else if (idade == 12)
            {
                Console.WriteLine("A partir dessa idade voce pode jogar");
            }
            else
            {
                Console.WriteLine("Voce nao tem idade para jogar!!");
            }


            /* Operadores Aritmeticos | Relacionais | logicos
             * Aritmeticos: (/) Divisao, (*) Multiplicacao, Soma e Subtracao  

            */
        }
    }
}