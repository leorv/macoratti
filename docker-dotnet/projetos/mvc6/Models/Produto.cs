using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc6.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string? Nome { get; set; }

        public string? Categoria { get; set; }

        public decimal Preco { get; set; }

        public Produto(int produtoId, string nome, string categoria, decimal preco = 0)
        {
            this.ProdutoId = produtoId;
            this.Nome = nome;
            this.Preco = preco;
            this.Categoria = categoria;
        }
    }
}