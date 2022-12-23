using Application.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API_REST_MVC.Repositories;

public class UtilisateursContext : DbContext
{

    public UtilisateursContext(DbContextOptions<UtilisateursContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }

    public DbSet<Utilisateur> Utilisateurs { get; set; }
}