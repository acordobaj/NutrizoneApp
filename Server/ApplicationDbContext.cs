using Microsoft.EntityFrameworkCore;
using NutrizoneApp.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NutrizoneApp.Server
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AltaPaciente>().HasKey(x => new { x.Id });

            base.OnModelCreating(modelBuilder);
        }

        public   DbSet<AltaPaciente>AltasPacientes { get; set; }
    }

}
