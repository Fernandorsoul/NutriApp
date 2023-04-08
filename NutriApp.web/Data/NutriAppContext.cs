
using Microsoft.EntityFrameworkCore;
using NutriApp.web.Models;

namespace NutriApp.Data
    {
        public class NutriAppContext : DbContext
        {
            public NutriAppContext(DbContextOptions<NutriAppContext> options)
                : base(options)
            {
            }

            // Representa a tabela de usuários na base de dados
            public DbSet<Usuario> Usuarios { get; set; }
                 
            // Representa a tabela de alimentos na base de dados
            public DbSet<Alimento> Alimentos { get; set; }

            // Representa a tabela de refeições na base de dados
            public DbSet<Refeicao> Refeicoes { get; set; }

            // Representa a tabela de dietas na base de dados
            public DbSet<Dieta> Dietas { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Configuração da chave primária composta da tabela RefeicaoAlimento
                modelBuilder.Entity<RefeicaoAlimento>()
                    .HasKey(ra => new { ra.RefeicaoId, ra.AlimentoId });

                // Configuração da relação muitos-para-muitos entre as tabelas Refeicao e Alimento
                modelBuilder.Entity<RefeicaoAlimento>()
                    .HasOne(ra => ra.Refeicao)
                    .WithMany(r => r.RefeicaoAlimentos)
                    .HasForeignKey(ra => ra.RefeicaoId);

                modelBuilder.Entity<RefeicaoAlimento>()
                    .HasOne(ra => ra.Alimento)
                    .WithMany(a => a.RefeicaoAlimentos)
                    .HasForeignKey(ra => ra.AlimentoId);

                // Configuração da chave estrangeira da tabela Refeicao
                //modelBuilder.Entity<Refeicao>()
                //    .HasOne(r => r.Dieta)
                //    .WithMany(d => d.Refeicoes)
                //    .HasForeignKey(r => r.DietaId);

                // Configuração da chave estrangeira da tabela RefeicaoAlimento
                modelBuilder.Entity<RefeicaoAlimento>()
                    .HasOne(ra => ra.Alimento)
                    .WithMany(a => a.RefeicaoAlimentos)
                    .HasForeignKey(ra => ra.AlimentoId);

                modelBuilder.Entity<RefeicaoAlimento>()
                    .HasOne(ra => ra.Refeicao)
                    .WithMany(r => r.RefeicaoAlimentos)
                    .HasForeignKey(ra => ra.RefeicaoId);
            }
        }
    }
