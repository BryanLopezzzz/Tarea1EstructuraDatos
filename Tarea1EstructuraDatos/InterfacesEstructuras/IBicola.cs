namespace Tarea1EstructuraDatos.InterfacesEstructuras;

public interface IBicola<T>
{
    void EncolarFrente(T objeto);  
    void EncolarFinal(T objeto);  
    T DesencolarFrente();    
    T DesencolarFinal();      
    T PeekFrente();           
    T PeekFinal();           
    bool IsEmpty();             
    int Count { get; } 
}