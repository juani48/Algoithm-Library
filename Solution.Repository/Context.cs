using Microsoft.EntityFrameworkCore;
using Solution.Aplication.Entity;

namespace Solution.Repository;

public class Context : DbContext
{
    public DbSet<Cube> Cubes{ get; set; }
    public DbSet<Algorithm> Algorithms{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=DataBase.db");
    }
}
