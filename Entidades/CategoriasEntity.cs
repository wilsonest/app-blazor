using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades
{
    public class CategoriasEntity
    {
        [Key]
        [StringLength(50)]
        public string CategoriaId { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoriasNombre { get; set; }

        public ICollection<ProductoEntity> productos { get; set; }

    }
}
