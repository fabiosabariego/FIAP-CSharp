using _02_LivroEbook.Models;
using System.Drawing;

namespace _02_LivroEbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ebook ebook = new Ebook();

            ebook.Titulo = "Back-End Java";
            ebook.Autor = "Eduardo Santana";
            ebook.Categoria = "Programacao";
            ebook.Valor = 49.90;
            ebook.MarcaDagua = "horacio@etec.sp.gov.br";
            Console.WriteLine($"Valor do Ebook: R${Math.Round(ebook.Valor, 2)}");
            ebook.AplicarDesconto();
            Console.WriteLine($"Valor do Ebook com Desconto: R${Math.Round(ebook.Valor, 2)}");
        }
    }
}