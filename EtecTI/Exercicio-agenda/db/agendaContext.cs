using Microsoft.EntityFrameworkCore;

namespace Exercicio_agenda.db
{
  public partial class agendaContext : DbContext
  {
    public agendaContext()
    {
    }

    public agendaContext(DbContextOptions<agendaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contato> Contatos { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseMySql("server=localhost;port=3306;user=william;password=root;database=agenda", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.UseCollation("utf8_general_ci")
          .HasCharSet("utf8");

      modelBuilder.Entity<Contato>(entity =>
      {
        entity.ToTable("contato");

        entity.HasIndex(e => e.Nome, "nome_UNIQUE")
                  .IsUnique();

        entity.Property(e => e.Id).HasColumnName("id");

        entity.Property(e => e.Estrelas).HasColumnName("estrelas");

        entity.Property(e => e.Fone)
                  .HasMaxLength(20)
                  .HasColumnName("fone");

        entity.Property(e => e.Nome)
                  .HasMaxLength(50)
                  .HasColumnName("nome");
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
