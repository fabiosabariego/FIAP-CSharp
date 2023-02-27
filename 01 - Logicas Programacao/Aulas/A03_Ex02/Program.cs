namespace A03_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user;

            Console.Write("Digite o usuario: ");
            user = Console.ReadLine(); 
            
            if(user != "administrador")
            {
                Console.WriteLine("Usuario sem poder administrativo, tarefas Bloqueadas!!");
            }
            else
            {
                Console.WriteLine("Usuario administrador, sistema liberado!");
            }

        }
    }
}