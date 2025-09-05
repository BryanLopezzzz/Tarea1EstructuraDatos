namespace Tarea1EstructuraDatos.InterfacesEstructuras;

public interface ICola<T>
{
    void Encolar(T objeto);  
    T Desencolar();         
    T Peek();               
    bool IsEmpty();       
    int Count { get; } 
}