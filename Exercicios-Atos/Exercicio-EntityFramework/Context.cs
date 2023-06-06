using Exercicio_EntityFramework.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_EntityFramework
{
    internal class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Email> Emails { get; set; }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["EntityAtos"];

            string retorno = "";
            if (settings != null)
            {
                retorno = settings.ConnectionString;
            }

            optionsBuilder.UseSqlServer(retorno);
            optionsBuilder.UseLazyLoadingProxies();
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(e => e.Emails)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
       
    }  
}

