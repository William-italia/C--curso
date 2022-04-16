using System;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_tarefas.db
{
  public partial class tarefasContext : DbContext
  {
    public tarefasContext()
    {
    }

    public tarefasContext(DbContextOptions<tarefasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Tarefa> Tarefas { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseMySql("server=localhost;port=3306;user=william;password=root;database=tarefas", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.UseCollation("utf8_general_ci")
          .HasCharSet("utf8");

      modelBuilder.Entity<Tarefa>(entity =>
      {
        entity.ToTable("tarefa");

        entity.Property(e => e.Id).HasColumnName("id");

        entity.Property(e => e.Concluida).HasColumnName("concluida");

        entity.Property(e => e.Descricao)
                  .HasMaxLength(200)
                  .HasColumnName("descricao");
      });

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
