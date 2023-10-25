using System.ComponentModel.DataAnnotations.Schema;

namespace Tcc.Models
{
    public class Crianca
    { 
        public int Id { get; set; }
        public string? NomeCrianca { get; set; }
        public int Idade { get; set; }
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

    }
}
