using DataAccess;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Produto
    {
        public static List<ProductoEntity> ProductoList()
        {
            using (var db = new InventarioContext())
            {
                return db.Productos.ToList();
            }
        }
        public static ProductoEntity ProductoById(string Producto)
        {
            using (var db = new InventarioContext())
            {
                return db.Productos.ToList().FirstOrDefault(p => p.ProductoNombre == Producto);
            }
        }

        public static void CreateProducto(ProductoEntity oProducto)
        {
            using (var db = new InventarioContext())
            {
                db.Productos.Add(oProducto);
                db.SaveChanges();
            }
        }

        public static void UpdateProducto(ProductoEntity oCategoria)
        {
            using (var db = new InventarioContext())
            {
                db.Productos.Update(oCategoria);
                db.SaveChanges();
            }
        }
    }
}
