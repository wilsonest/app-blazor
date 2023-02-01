using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
//ctrl +k +d identar
namespace DataAccess
{
    public class InventarioContext : DbContext
    {
        public DbSet<ProductoEntity> Productos { get; set; }
        public DbSet<CategoriasEntity> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            if (!option.IsConfigured)
            {
                option.UseSqlServer("Server=ZIBOR-64517; Database = galeria; Trusted_Connection = True; MultipleActiveResultSets = True;");
            }
        }
    }
}
