namespace A03_Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            double aulasDadas, aulasAssistidas, frequencia;

            Console.Write("Digite a primeira nota: ");
            double.TryParse(Console.ReadLine(), out nota1);

            Console.Write("Digite a segunda nota: ");
            double.TryParse(Console.ReadLine(), out nota2);

            Console.Write("Digite a quantidade de aulas dadas: ");
            double.TryParse(Console.ReadLine(), out aulasDadas);

            Console.Write("Digite a quantidade de aulas assistidas: ");
            double.TryParse(Console.ReadLine(), out aulasAssistidas);

            frequencia = Convert.ToDouble((aulasAssistidas / aulasDadas) * 100);
            media = Math.Round(Convert.ToDouble((nota1 + nota2)/2), 2);
            
            if(media >= 7.0 && frequencia >= 75)
            {
                Console.Write("Aluno Aprovado com ");
            }
            else
            {
                Console.Write("Aluno Reprovado com ");
            }

            Console.WriteLine($"Media: {media} / Frequencia: {frequencia}%");

        }
    }
}