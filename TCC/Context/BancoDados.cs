using Microsoft.EntityFrameworkCore;

using Tcc.Models;

 namespace Tcc.Context
{
    public class BancoDados : DbContext
    { 
        public BancoDados(DbContextOptions<BancoDados> options) : base(options) { }
        public DbSet<Crianca> Crianca { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Jogada> Jogada { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}


  
