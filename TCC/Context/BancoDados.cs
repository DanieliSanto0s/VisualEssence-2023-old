using Microsoft.EntityFrameworkCore;
using Tcc.Models;

namespace Tcc.Context
{
    public class BancoDados : DbContext
    { 
        public BancoDados(DbContextOptions<BancoDados> options) : base(options) { }

        public DbSet<Crianca> Criancas { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Jogada> Jogadas { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }

    
}
