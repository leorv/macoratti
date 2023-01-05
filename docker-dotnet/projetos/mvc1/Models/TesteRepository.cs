using System;
using System.Collections.Generic;

namespace mvc1.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]{
            new Produto{ ProdutoId=1, Nome="Caneta", Categoria="Material", Preco=2.0M},
            new Produto{ ProdutoId=2,Nome="Borracha", Categoria="Material", Preco=1.5M},
            new Produto{ ProdutoId=3,Nome="Estojo", Categoria="Material", Preco=5.0M}
        };
        public IEnumerable<Produto> Produtos {get => produtos;}
    }
}