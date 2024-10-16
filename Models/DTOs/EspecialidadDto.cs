using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs
{
    public class EspecialidadDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "El nombre debe ser Minimo 1 Maximo 60 caracteres")]
        public string NombreEspecialidad { get; set; }

        [StringLength(60, MinimumLength = 1, ErrorMessage = "La Descripcion debe ser Minimo 1 Maximo 100 caracteres")]
        public string Descripcion { get; set; }

        public int Estado { get; set; } // 1 - 0
    }
}
