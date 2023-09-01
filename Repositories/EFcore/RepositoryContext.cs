using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFcore.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFcore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        //Tablo adını belirledik
        public DbSet<Book> Books { get; set; }

        //Konfigürasyonu implemente ettiğimiz yer
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
        }
    }
}
