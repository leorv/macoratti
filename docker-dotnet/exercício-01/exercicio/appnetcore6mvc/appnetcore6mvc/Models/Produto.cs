namespace appnetcore6mvc.Models;
public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Categoria { get; set; }
    public decimal Preco { get; set; }
    public Produto()
    { }
    public Produto(int id, string? nome, string? categoria, decimal preco)
    {
        Id = id;
        Nome = nome;
        Categoria = categoria;
        Preco = preco;
    }

}