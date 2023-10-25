using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tcc.Models
{
    public class Jogada
    {
        public int Id { get; set; }
        public DateTime DataJogou { get; set; }
        public int PontuacaoJogo { get; set; }

        public int IdCrianca { get; set; }

        [ForeignKey("IdCrianca")]
        public Crianca Crianca { get; set; }

        public int IdJogo { get; set; }
        
        [ForeignKey("IdJogo")]
        public Jogo Jogo { get; set; }

    }
}
