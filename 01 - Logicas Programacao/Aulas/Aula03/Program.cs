namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desvios logicos
            //Switch Case
            // Testando Usuario e senha

            /*
            string user;
            int senha;

            Console.Write("Digite seu login: ");
            user = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            int.TryParse(Console.ReadLine(), out senha);

            if (user == "admin" && senha == 123)
            {
                Console.WriteLine($"Sistema acessado com Sucesso!! Seja bem vindo {user}");
            }
            else
            {
                Console.WriteLine("Usuario ou Senha Invalidos!!");
            }
            */

            // TRABALHANDO COM SWITCH / CASE

            int codigo;
            string mensagem;

            Console.Write("Digite o Codigo: ");
            int.TryParse(Console.ReadLine(), out codigo);

            switch (codigo)
            {
                case 1:
                    mensagem = "Voce escolheu receber um elogio profissional!";
                    break;
                
                case 2:
                    mensagem = "Voce escolheu receber um elogio fisico!";
                    break;

                case 3:
                    mensagem = "Voce escolheu receber um elogio pessoal!";
                    break;

                default:
                    mensagem = "Codigo informado invalido!";
                    break;
            }

            Console.WriteLine(mensagem);
        }
    }
}