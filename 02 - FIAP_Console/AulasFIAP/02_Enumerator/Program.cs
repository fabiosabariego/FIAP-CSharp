using _02_Enumerator.Models;

namespace _02_Enumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario("Fabio");
            func.EstadoCivil = Enums.EstadoCivilEnum.Casado;

            
        }
    }
}