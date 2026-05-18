# 📦 Sistema de Gerenciamento de Produtos em C#

## 📖 Descrição

Este projeto foi desenvolvido em **C#** como atividade acadêmica de reposição, com o objetivo de aplicar conceitos importantes da linguagem e da programação orientada a objetos.

O sistema simula um pequeno ambiente de gerenciamento de produtos, catálogo de vendas e processamento de logs, utilizando recursos modernos do C# como:

- Generics
- Collections
- LINQ
- Dictionary
- Lazy Evaluation
- yield return

---

# ⚙️ Funcionalidades Desenvolvidas

## 🛒 Classe Produto

Implementação da classe `Produto` com:

- Cadastro de produtos
- Comparação de igualdade por SKU utilizando `IEquatable<Produto>`
- Ordenação natural utilizando `IComparable<Produto>`
- Ordenação baseada na quantidade em estoque

---

## 📚 Repositório Genérico

Implementação da classe:

```csharp
Armazem<T>
```

Utilizando:

- Generics
- Constraints
- `List<T>`

---

## 🔎 Catálogo de Vendas

Implementação de:

```csharp
Dictionary<string, Produto>
```

Funcionalidades:

- Busca rápida por SKU
- Melhor desempenho de pesquisa (`O(1)`)
- Utilização de `TryGetValue`
- Prevenção de exceções `KeyNotFoundException`

---

## 🧠 LINQ e Avaliação Diferida

Aplicação dos conceitos de:

- Lazy Evaluation
- Materialização Imediata com `ToList()`

Demonstrando como alterações em coleções podem afetar consultas LINQ dinâmicas.

---

## 📄 Processamento de Logs

Uso de:

```csharp
IEnumerable<string>
yield return
```

Para simular leitura de grandes volumes de dados sob demanda, evitando alto consumo de memória.

---

# 🛠️ Tecnologias Utilizadas

- C#
- .NET
- LINQ
- Collections
- Generics
- Dictionary
- IEnumerable

---

# 📁 Estrutura do Projeto

```txt
Projeto/

├── Armazem.cs
├── CatalogoVendas.cs
├── Produto.cs
├── Produto.csproj
├── Program.cs
└── SistemaLogs.cs
```

---

# 🎯 Objetivo

O objetivo deste projeto é reforçar conceitos importantes da linguagem C# através da implementação prática de estruturas e recursos utilizados no desenvolvimento de software.

---

# 👩‍💻 Autor

Projeto desenvolvido por Lara como atividade acadêmica de reposição.
