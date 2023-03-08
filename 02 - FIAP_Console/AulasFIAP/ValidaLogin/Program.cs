namespace ValidaLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user;
            int pwd;

            Console.Write("Digite o Usuario: ");
            user = Console.ReadLine();

            Console.Write("Digite a Senha: ");
            int.TryParse(Console.ReadLine(), out pwd);


            if (ValidarLogin(user, pwd) == true)
            {
                Console.WriteLine("Usuario e Senha Ok, Sistema Acessado!!");
            }
            else
            {
                Console.WriteLine("Usuario ou Senha nao Compativeis, tente outra vez!!");
            }
        }


        public static bool ValidarLogin(string user, int senha)
        {
            if (user == "admin" && senha == 123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}