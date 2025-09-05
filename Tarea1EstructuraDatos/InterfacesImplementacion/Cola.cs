using Tarea1EstructuraDatos.InterfacesEstructuras;
using System.Collections.Generic;

namespace Tarea1EstructuraDatos.InterfacesImplementacion;

public class Cola<T> : ICola<T>
{
    private List<T> lista = new List<T>();

    public int Count
    {
        get { return lista.Count; }
    }

    public bool IsEmpty()
    {
        return lista.Count == 0;
    }

    public void Encolar(T objeto)
    {
        lista.Add(objeto);
    }

    public T Desencolar()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La cola está vacía.");
        }
        T objeto = lista[0];
        lista.RemoveAt(0);
        return objeto;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La cola está vacía.");
        }
        return lista[0];
    }
}
