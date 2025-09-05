using Tarea1EstructuraDatos.InterfacesEstructuras;
using System.Collections.Generic;

namespace Tarea1EstructuraDatos.InterfacesImplementacion;

public class Pila<T> : IPila<T>
{
    private List<T> lista = new List<T>();

    public int Count
    {
        get { return lista.Count; } //Tiene el get aquí porque también puede tener set el Count por una propiedad.
    }                                  //Lo uso para delimitar que solo use get.

    public bool IsEmpty()
    {
        return lista.Count == 0;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La pila está vacía. Error");
        }
        return lista[lista.Count - 1];
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La pila está vacía. Error");
        }
        T objeto = lista[lista.Count - 1];
        lista.RemoveAt(lista.Count - 1);
        return objeto;
    }

    public void Push(T objeto)
    {
        lista.Add(objeto);
    }
}