using System.Collections.Generic;

public class Armazem<T> where T : class, new()
{
    private List<T> itens = new List<T>();

    public void Adicionar(T item)
    {
        itens.Add(item);
    }
}