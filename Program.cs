CatalogoVendas catalogo = new CatalogoVendas();

Produto p1 = new Produto
{
    Sku = "A1",
    Nome = "Mouse",
    Preco = 100,
    QuantidadeEstoque = 10
};

catalogo.AdicionarProduto(p1);

Produto resultado = catalogo.BuscarProdutoParaVenda("A1");

Console.WriteLine(resultado.Nome);
Console.WriteLine(resultado.Preco);
Console.WriteLine(resultado.QuantidadeEstoque);

SistemaLogs logs = new SistemaLogs();

int contador = 0;

foreach (string log in logs.LerLogsMacicos())
{
    Console.WriteLine(log);

    contador++;

    if (contador == 10)
        break;
}


/* 
 
Resposta do "O Fantasma da Execução Diferida (LINQ)" 

1- Sim, o produto "Cabo HDMI" será contabilizado, porque a consulta LINQ utiliza avaliação diferida.
O método Where() apenas define a consulta, mas sua execução só ocorre quando Count() é chamado. Como o produto
foi adicionado antes da execução da consulta, ele passa a fazer parte do resultado.

2 - 
Correção

var produtosEmFalta = listaEstoque
    .Where(p => p.QuantidadeEstoque < 5)
    .ToList();
 
O método ToList() realiza a materialização imediata da consulta, 
criando uma cópia independente dos dados naquele instante e impedindo que alteraçoes futuras na lista original afetem
o resultado guardado em produtosEmFalta.
 
*/