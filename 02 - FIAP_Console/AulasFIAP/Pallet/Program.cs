using Pallet.Models;

namespace Pallet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando o Objeto Pallet
            Pallete p1 = new Pallete("ABC001", 280);
            Console.WriteLine(p1.Consultar());
        }
    }
}