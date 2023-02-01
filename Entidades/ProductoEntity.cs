using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades
{
    public class ProductoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoId { get; set; }
        [StringLength(100)]
        public string ProductoNombre { get; set; }
        [StringLength(600)]
        public string ProductoDescripcion { get; set; }
        [StringLength(600)]
        public string ProductoImagen { get; set; }

        public string CategoriaId { get; set; }
        public CategoriasEntity Categoria { get; set; }
    }
}
