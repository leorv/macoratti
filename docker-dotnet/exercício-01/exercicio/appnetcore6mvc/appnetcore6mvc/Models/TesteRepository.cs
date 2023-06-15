namespace appnetcore6mvc.Models;

public class TesteRepository : IRepository
{
    private static Produto[] produtos = new Produto[] {
        new Produto {
            Id=1, Nome="Caneta", Categoria="Material", Preco=2.0M
        },
        new Produto {
            Id=2, Nome="Borracha", Categoria="Material", Preco=1.5M
        },
        new Produto {
            Id=3, Nome="Estojo", Categoria="Material", Preco=3.0M
        }
    };

    public IEnumerable<Produto> Produtos { get => produtos; }
}