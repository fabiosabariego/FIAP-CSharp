namespace GrausCelsiusReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempC;
            Console.Write("Digite a Temperatura em °C: ");
            double.TryParse(Console.ReadLine(), out tempC);

            Console.WriteLine($"Temperatura em Farenheit: {convTemp(tempC)}°F");
        }

        public static double convTemp(double tempCelsius)
        {
            return tempCelsius * 1.8 + 32;
        }
    }
}