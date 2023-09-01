using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFcore.Config
{
    // kitaplar için tablo açıldığında tabloya ilk yazılacak verilerin konfigüre edildiği yer.(ayrıca kolon isimleri de burda tanımlanır)
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Price = 20, Title = "ak kürt" },
                new Book { Id = 2, Price = 800, Title = "cebimde 10 lira" },
                new Book { Id = 3, Price = 200, Title = "kırmızı başlıklı kız" });
        }
    }
}
