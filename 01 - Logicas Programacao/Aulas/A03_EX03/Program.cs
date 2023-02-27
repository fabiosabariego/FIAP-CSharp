namespace A03_EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l1;
            int l2;
            int valZ;

            Console.Write("Digite o primeiro Valor: ");
            int.TryParse(Console.ReadLine(), out l1);

            Console.Write("Digite o segundo Valor: ");
            int.TryParse(Console.ReadLine(), out l2);

            Console.Write("Digite o terceiro Valor: ");
            int.TryParse(Console.ReadLine(), out valZ);

            // Verifica se e um triangulo (A soma de 2 lados nao pode ser maior que o terceiro lado)
            if(l1 < (l2 + valZ) && l2 < (l1 + valZ) && valZ < (l1 + l2))
            {
                Console.Write("E um triangulo do tipo -> ");

                if(l1 == l2 && l2 == valZ)
                {
                    Console.WriteLine("Equilatero");
                }
                else if(l1 == l2 || l1 == valZ || l2 == valZ)
                {
                    Console.WriteLine("Isosceles");
                }
                else if(l1 != l2 && l1 != valZ && l2 != valZ)
                {
                    Console.WriteLine("Escaleno");
                }
                else
                {
                    Console.WriteLine("Nao e" +
                        " um triangulo!");
                }
            }

        }
    }
}