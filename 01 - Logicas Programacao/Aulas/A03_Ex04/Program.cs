namespace A03_Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int mes;
            string mensagem;

            Console.Write("Digite o mes do ano: ");
            int.TryParse(Console.ReadLine(), out mes);

            switch (mes)
            {
                case 1:
                    mensagem = "Janeiro";
                    break;
                case 2:
                    mensagem = "Fevereiro";
                    break;
                case 3:
                    mensagem = "Março";
                    break;
                case 4:
                    mensagem = "Abril";
                    break;
                case 5:
                    mensagem = "Maio";
                    break;
                case 6:
                    mensagem = "Junho";
                    break;
                case 7:
                    mensagem = "Julho";
                    break;
                case 8:
                    mensagem = "Agosto";
                    break;
                case 9:
                    mensagem = "Setembro";
                    break;
                case 10:
                    mensagem = "Outubro";
                    break;
                case 11:
                    mensagem = "Novembro";
                    break;
                case 12:
                    mensagem = "Dezembro";
                    break;
                default:
                    mensagem = "Mes nao existente!";
                    break;
            }

            Console.WriteLine(mensagem);

        }
    }
}