using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc6.Models
{
    public class TesteRepository : IRepository
    {
        private static Produto[] produtos = new Produto[]{
            new Produto( 1, "Caneta", "Material", 2.0M),
            new Produto( 2,"Borracha", "Material", 1.5M),
            new Produto( 3,"Estojo", "Material", 5.0M)
        };
        public IEnumerable<Produto> Produtos { get => produtos; }
    }
}