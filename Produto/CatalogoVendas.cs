using System.Collections.Generic;

public class CatalogoVendas
{
    private Dictionary<string, Produto> produtos =
        new Dictionary<string, Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto.Sku, produto);
    }

    public Produto BuscarProdutoParaVenda(string sku)
    {
        Produto produto;

        bool encontrou = produtos.TryGetValue(sku, out produto);

        if (encontrou)
        {
            return produto;
        }

        return null;
    }
}