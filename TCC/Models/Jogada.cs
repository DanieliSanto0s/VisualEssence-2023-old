using Microsoft.EntityFrameworkCore.Metadata;

namespace Tcc.Models
{
    public class Jogada
    {
        public Guid Id { get; set; }
        public DateTime DataJogou { get; set; }
        public int PontuacaoJogo { get; set; }
        public int IdCrianca { get; set; }
        public int IdJogo { get; set; }


 
    }
}
