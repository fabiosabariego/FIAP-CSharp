namespace SolTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lerTemp();
        }

        public static void lerTemp()
        {
            double tempC;
            Console.Write("Digite a Temperatura em °C: ");
            double.TryParse(Console.ReadLine(), out tempC);
            convTemp(tempC);
        }

        public static void convTemp(double tempCelsius)
        {
            double tempF;
            tempF = tempCelsius * 1.8 + 32;
            Console.WriteLine($"Temperatura em Farenheit: {tempF}°F");
        }
    }
}