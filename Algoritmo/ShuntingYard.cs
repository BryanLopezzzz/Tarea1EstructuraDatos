

namespace Tarea1EstructuraDatos.Algortimo;

public class ShuntingYard
{
    public static List<Token> ConvertirAPostfija(List<Token> tokens)
    {
        var salida = new List<Token>();
        var pila = new Stack<Token>();
        foreach (var t in tokens)
        {
            if (t.EsNumero) salida.Add(t);
            else if (t.EsOperador)
            {
                while (pila.Count > 0 && pila.Peek().EsOperador && pila.Peek().Prioridad >= t.Prioridad)
                    salida.Add(pila.Pop());
                pila.Push(t);
            }
            else if (t.EsParentesis && t.Parentesis == '(') pila.Push(t);
            else if (t.EsParentesis && t.Parentesis == ')')
            {
                while (!(pila.Peek().EsParentesis && pila.Peek().Parentesis == '(')) salida.Add(pila.Pop());
                pila.Pop();
            }
        }
        while (pila.Count > 0) salida.Add(pila.Pop());
        return salida;
    }
    
    public static int EvaluarPostfija(List<Token> postfija)
    {
        var pila = new Stack<int>();
        foreach (var t in postfija)
            if (t.EsNumero) pila.Push(t.ValorNumero.Value);
            else
            {
                int b = pila.Pop(), a = pila.Pop();
                pila.Push(t.Operador switch { '+' => a + b, '-' => a - b, '*' => a * b, '/' => a / b, _ => 0 });
            }
        return pila.Pop();
    }

}