using System;
public class Produto : IEquatable<Produto>, IComparable<Produto>
{
    public string Sku;
    public string Nome;
    public double Preco;
    public int QuantidadeEstoque;

    public bool Equals(Produto produto)
    {
        if (produto == null)
            return false;

        return Sku == produto.Sku;

    }

    public override bool Equals(Object obj)
    {
        return Equals(obj as Produto);
    }

    public override int GetHashCode()
    {
        return Sku.GetHashCode();

    }

    public int CompareTo(Produto produto)
    {
        return produto.QuantidadeEstoque.CompareTo(QuantidadeEstoque);
    }
}