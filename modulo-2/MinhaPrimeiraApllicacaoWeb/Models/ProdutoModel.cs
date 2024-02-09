namespace MinhaPrimeiraApllicacaoWeb.Models;

public class ProdutoModel{

    public int Id {get;set;}
    public string Nome { get; set; } //pq não em char?
    public string Descricao { get; set; } //pq não em char?
    public decimal Preco {get;set;} // pq não em double ou float  ?
    public bool EstaAtivo {get;set;}
}