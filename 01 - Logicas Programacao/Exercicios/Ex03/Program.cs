namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculo de Media de um Aluno

            float nota01;
            float nota02;
            float nota03;
            double media;

            Console.Write("Digite a primeira Nota: ");
            float.TryParse(Console.ReadLine(), out nota01);

            Console.Write("Digite a segunda Nota: ");
            float.TryParse(Console.ReadLine(), out nota02);

            Console.Write("Digite a terceira Nota: ");
            float.TryParse(Console.ReadLine(), out nota03);

            media = Convert.ToDouble((nota01 + nota02 + nota03) / 3);       //Calculo da media das 3 notas do Aluno

            Console.Write($"Media: {Math.Round(media, 1)} - ");             // Mostra no terminal a nota do aluno, limitando as casas decimais em 1

            if (media >= 7)
            {
                Console.WriteLine($"Aluno Aprovado!!");
            }
            else if (media >= 4 && media < 7)
            {
                Console.WriteLine($"Aluno em prova final!!");
            }
            else
            {
                Console.WriteLine($"Aluno Reprovado!!");
            }

        }
    }
}