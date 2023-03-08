namespace ValidarLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user;
            int pwd;
            bool resVerif;

            Console.Write("Digite o Usuario: ");
            user = Console.ReadLine();

            Console.Write("Digite a Senha: ");
            int.TryParse(Console.ReadLine(), out pwd);

            resVerif = ValidarLogin(user, pwd);

            if(resVerif == true)
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
            if(user == "admin" &&  senha == 123)
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