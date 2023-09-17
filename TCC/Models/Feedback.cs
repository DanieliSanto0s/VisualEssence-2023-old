namespace Tcc.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string? NomeUs { get; set; }
        public string? Email { get; set; }
        public string? Assunto { get; set; }
        public string? Descricao { get; set; }
        public int IdUsuario { get; set;}
    }
}
