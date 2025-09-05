using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1EstructuraDatos.Algortimo;

    public class Tokenizador
    {
        private static readonly Dictionary<char, int> Prioridades = new Dictionary<char, int>()
        {
            { '+', 1 },
            { '-', 1 },
            { '*', 2 },
            { '/', 2 }, 
        };
        public static List<Token> Analizar(string expresion)
        {
            var tokens = new List<Token>();
            var sb = new StringBuilder();

            foreach (char c in expresion.Replace(" ", "")) // quitar espacios
            {
                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
                else if (Prioridades.ContainsKey(c))
                {
                    // Guardar número acumulado antes del operador
                    if (sb.Length > 0)
                    {
                        tokens.Add(new Token
                        {
                            EsNumero = true,
                            ValorNumero = int.Parse(sb.ToString())
                        });
                        sb.Clear();
                    }
                    tokens.Add(new Token
                    {
                        EsOperador = true,
                        Operador = c,
                        Prioridad = Prioridades[c]
                    });
                }
                else if (c == '(' || c == ')')
                {
                    if (sb.Length > 0)
                    {
                        tokens.Add(new Token
                        {
                            EsNumero = true,
                            ValorNumero = int.Parse(sb.ToString())
                        });
                        sb.Clear();
                        if (c == '(')
                        {
                            tokens.Add(new Token
                            {
                                EsOperador = true,
                                Operador = '*',
                                Prioridad = Prioridades['*']
                            });
                        }
                    }
                    else if (c == '(' && tokens.Count > 0 && tokens[^1].EsParentesis && tokens[^1].Parentesis == ')')
                    {
                        // Caso ")(" → también multiplicación implícita
                        tokens.Add(new Token
                        {
                            EsOperador = true,
                            Operador = '*',
                            Prioridad = Prioridades['*']
                        });
                    }
                    tokens.Add(new Token
                    {
                        EsParentesis = true,
                        Parentesis = c
                    });
                }
                else
                {
                    throw new Exception($"Carácter no válido en la expresión: {c}");
                }
            }
            if (sb.Length > 0)
            {
                tokens.Add(new Token
                {
                    EsNumero = true,
                    ValorNumero = int.Parse(sb.ToString())
                });
            }

            return tokens;
        }
}