namespace Tarea1EstructuraDatos.InterfacesEstructuras;

public interface IPila <T>
{
    void Push(T objeto);    
    T Pop();               
    T Peek();             
    bool IsEmpty();        
    int Count { get; }    
}