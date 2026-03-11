namespace WebAPI.Models;

public class Personagem
{
    // O EF reconhece "Id" automaticamente como Chave Primária
    public int Id { get; set; } 
    
    public required string Nome { get; set; }
    public required string Tipo { get; set; }
}