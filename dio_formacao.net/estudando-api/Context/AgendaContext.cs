using estudando_api.Entities;
using Microsoft.EntityFrameworkCore;

public class AgendaContext : DbContext
{
    public DbSet<Contato> Contatos { get; set; }
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {}

    
}