namespace Tcc.Models
{
    public class Crianca
    {
        public Guid Id { get; set; }
        public string? NomeCrianca { get; set; }
        public DateTime DataNasc { get; set; }

        public int IdUsuario { get; set; }
    }
}
