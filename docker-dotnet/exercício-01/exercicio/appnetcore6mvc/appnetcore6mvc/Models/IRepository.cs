namespace appnetcore6mvc.Models;

public interface IRepository
{
    IEnumerable<Produto>? Produtos { get; }
}