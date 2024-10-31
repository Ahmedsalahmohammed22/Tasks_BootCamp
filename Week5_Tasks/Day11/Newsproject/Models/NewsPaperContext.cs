using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsproject.Models
{
    internal class NewsPaperContext:DbContext
    {
        public virtual DbSet<Author> authors { get; set; }
        public virtual DbSet<News> news { get; set; }
        public virtual DbSet<Catalog> catalogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=DESKTOP-OVKLF8O\\SQLEXPRESS;Database=Newspaper;Trusted_Connection=True;TrustServerCertificate=True");        
        }


    }
}
