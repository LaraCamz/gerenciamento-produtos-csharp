Sistema de Gerenciamento de Produtos em C#
Descrição

Este projeto foi desenvolvido em C# como atividade de reposição acadêmica, com o objetivo de aplicar conceitos de programação orientada a objetos, coleções genéricas, LINQ e processamento sob demanda.

O sistema simula um pequeno ambiente de gerenciamento de produtos e catálogo de vendas, utilizando recursos importantes da linguagem C#.

Funcionalidades Desenvolvidas
Classe Produto
Cadastro de produtos
Comparação de igualdade por SKU utilizando IEquatable<Produto>
Ordenação por quantidade em estoque utilizando IComparable<Produto>
Repositório Genérico

Implementação da classe:

Armazem<T>

Utilizando:

Generics
Constraints
List<T>
Catálogo de Vendas

Implementação de:

Dictionary<string, Produto>
Busca rápida por SKU
Utilização de TryGetValue
LINQ e Avaliação Diferida

Aplicação dos conceitos de:

Lazy Evaluation
Materialização Imediata com ToList()
Processamento de Logs

Uso de:

IEnumerable<string>
yield return

Para simular leitura de grandes volumes de dados sob demanda.

Tecnologias Utilizadas
C#
.NET
LINQ
Collections
Generics
Estrutura do Projeto
Projeto/

│ Produto

├── Armazem.cs 
├── CatalogoVendas.cs
├── Produto.cs
├── Produto.csproj
├── Program.cs
└── SistemaLogs.cs
Objetivo

O objetivo deste projeto é reforçar conceitos importantes da linguagem C# através da implementação prática de estruturas e recursos utilizados no desenvolvimento de software.

Autor
Projeto desenvolvido por Lara
