using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
   public class B_Categoria
    {
        public static List<CategoriasEntity> CategoriaList()
        {
            using (var db = new InventarioContext())
                return db.Categorias.ToList();
        }

        public void CreateCategoria(CategoriasEntity oCategoria)
        {
            using (var db = new InventarioContext())
            {
                db.Categorias.Add(oCategoria);
                db.SaveChanges();
            }
        }

        public void UpdateCategoria(CategoriasEntity oCategoria)
        {
            using (var db = new InventarioContext())
            {
                db.Categorias.Update(oCategoria);
                db.SaveChanges();
            }
        }
    }
}
