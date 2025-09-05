using Tarea1EstructuraDatos.Algortimo;

namespace Tarea1EstructuraDatos;

internal class Program
{
    static void Main(string[] args)
    {
        // ejemplo: "12 + 3 * 45 - 6 / 2 * (1-2)";
        Console.WriteLine("Por favor escribe una expresión:");
        var expresion = Console.ReadLine();

        // 1. Tokenizar
        var tokens = Tokenizador.Analizar(expresion);
        Console.WriteLine("\n=== Tokens ===");
        foreach (var t in tokens) Console.Write(t);
        Console.WriteLine();

        // 2. Convertir a postfija
        var postfija = ShuntingYard.ConvertirAPostfija(tokens);
        Console.WriteLine("\n=== Postfija ===");
        foreach (var t in postfija) Console.Write(t);
        Console.WriteLine();

        // 3. Evaluar
        var resultado = ShuntingYard.EvaluarPostfija(postfija);
        Console.WriteLine($"\n=== Resultado ===\n{resultado}");

        Console.ReadKey();
    }
}