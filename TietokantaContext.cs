using System;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
public partial class TietokantaContext : DbContext
    {
        public TietokantaContext()
        {
        }

        public TietokantaContext(DbContextOptions<TietokantaContext> options)
            : base(options)
        {
        }
        public DbSet<tietue> Tietueet {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;database=testikanta;user=topias;password=Asd123!",new MySqlServerVersion(new Version(10, 6, 4)));
            }
        }
    }