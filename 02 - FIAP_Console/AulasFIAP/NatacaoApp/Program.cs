namespace NatacaoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite a idade do nadador: ");
            int.TryParse(Console.ReadLine(), out idade);

            Console.WriteLine($"Categoria: {CategoriaNadador(idade)}");

        }

        public static string CategoriaNadador(int idade)
        {
            if (idade >= 5 && idade <= 7)
            {
                return "Infantil A";
            }
            else if (idade >= 8 && idade <= 7)
            {
                return "Infantil B";
            }
            else if (idade >= 12 && idade <= 13)
            {
                return "Juvenil A";
            }
            else if (idade >= 14 && idade <= 17)
            {
                return "Juvenil B";
            }
            else if (idade >= 18)
            {
                return "Adultos";
            }
            else
            {
                return "Nao permitido, muito novo!";
            }
        }
    }
}