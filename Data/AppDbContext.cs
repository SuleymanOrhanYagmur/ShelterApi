using Microsoft.EntityFrameworkCore;
using ShelterApi.Models;

namespace ShelterApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Dog> Dogs => Set<Dog>();
    public DbSet<Cat> Cats => Set<Cat>();
    public DbSet<Bird> Birds => Set<Bird>();
}