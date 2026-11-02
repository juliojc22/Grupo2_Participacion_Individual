using Microsoft.EntityFrameworkCore;

public class Grupo2Context(DbContextOptions<Grupo2Context> options) : DbContext(options)
{
    public DbSet<Grupo2.Models.Carrera> Carrera { get; set; } = default!;
    public DbSet<Grupo2.Models.Facultad> Facultad { get; set; } = default!;
}



