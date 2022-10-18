using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeriBilisimCase.Models;

namespace VeriBilisimCase.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Aday> Adays { get; set; }
        public DbSet<IL> ILs { get; set; }
        public DbSet<Ilce> Ilces { get; set; }

    }
}
