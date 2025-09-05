
namespace Tarea1EstructuraDatos.Algortimo;
    public class Token
    {
        public bool EsNumero { get; set; }
        public bool EsOperador { get; set; }
        public bool EsParentesis { get; set; }
        public int? ValorNumero { get; set; }
        public char? Operador { get; set; }
        public char? Parentesis { get; set; }
        public int Prioridad { get; set; } // 0 = no aplica, 1 = +/-, 2 = */, /

        public override string ToString()
        {
            if (EsNumero)
            {
                return $"[{ValorNumero}]";
            }
            else if (EsParentesis)
            {
                return $"[{Parentesis}]";
            }
            else 
            {
                return $"[{Operador}]";
            }
        }
}
