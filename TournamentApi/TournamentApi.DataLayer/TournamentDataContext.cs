using System;
using Microsoft.EntityFrameworkCore;
using TournamentApi.Model;

namespace TournamentApi.DataLayer
{
    public class TournamentDataContext : DbContext
    {

        public TournamentDataContext(DbContextOptions<TournamentDataContext> options) : base(options)
        {
            
        }

        public DbSet<Tournament> Tournamnets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tournament>().ToTable("Tournaments");
        }
    }
}
