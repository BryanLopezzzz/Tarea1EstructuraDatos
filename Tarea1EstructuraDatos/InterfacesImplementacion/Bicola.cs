using Tarea1EstructuraDatos.InterfacesEstructuras;
using System.Collections.Generic;

namespace Tarea1EstructuraDatos.InterfacesImplementacion;

public class Bicola<T> : IBicola<T>
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

    public void EncolarFrente(T objeto)
    {
        lista.Insert(0, objeto);
    }

    public void EncolarFinal(T objeto)
    {
        lista.Add(objeto);
    }

    public T DesencolarFrente()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La bicola está vacía.");
        }
        T objeto = lista[0];
        lista.RemoveAt(0);
        return objeto;
    }

    public T DesencolarFinal()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La bicola está vacía.");
        }
        T objeto = lista[lista.Count - 1];
        lista.RemoveAt(lista.Count - 1);
        return objeto;
    }

    public T PeekFrente()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La bicola está vacía.");
        }
        return lista[0];
    }

    public T PeekFinal()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La bicola está vacía.");
        }
        return lista[lista.Count - 1];
    }
}