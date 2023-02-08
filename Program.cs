namespace Matematicas2
{
    class EjerciciosLibMath
    {
        public static void Main(String[] args)
        {
            double numeroA, numeroB, resultado;
            Console.WriteLine("Introduce número 1: ");
            numeroA = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce número 2: ");
            numeroB = int.Parse(Console.ReadLine());
            resultado = Math.Abs(numeroA);
            Console.WriteLine("VALOR ABSOLUTO: " + resultado);
            resultado = Math.Pow(numeroA, numeroB);
            Console.WriteLine(numeroA + " ELEVADO A "+numeroB+" = " + resultado);
            resultado = Math.Sqrt(numeroA);
            Console.WriteLine("RAIZ CUADRADA: " + resultado);
            resultado = Math.Sin(numeroA);
            Console.WriteLine("SENO: " + resultado);
            resultado = Math.Cos(numeroA);
            Console.WriteLine("COSENO: " + resultado);
            resultado = Math.Max(numeroA, numeroB);
            Console.WriteLine("NUMERO MAXIMO: " + resultado);
            resultado = Math.Min(numeroA, numeroB);
            Console.WriteLine("NUMERO MINIMO: " + resultado);
            resultado = Math.Truncate(numeroA/numeroB);
            Console.WriteLine("PARTE ENTERA: " + resultado);
            resultado = Math.Round(numeroA/numeroB, 0);
            Console.WriteLine("REDONDEO: " + resultado);
        }
    }
}