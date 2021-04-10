using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vaccinator.Models;

namespace Vaccinator.Models
{
    public class ContextBDD : DbContext
    {
        public DbSet<Injection> Injections { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<VaccinType> VaccinTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=vaccinator.db");
        }

        public DbSet<Vaccinator.Models.Personne> Personne { get; set; }

        public DbSet<Vaccinator.Models.VaccinType> VaccinType { get; set; }

        public DbSet<Vaccinator.Models.Injection> Injection { get; set; }
    }
}