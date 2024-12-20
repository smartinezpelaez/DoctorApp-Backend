﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entidades
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Apellido es requerido")]
        [StringLength(60, MinimumLength =1, ErrorMessage ="Apellidos debe ser Minimo 1 Maximo 60 caracteres")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Nombres debe ser Minimo 1 Maximo 60 caracteres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Direccion es requerido")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Direccion debe ser Minimo 1 Maximo 100 caracteres")]
        public string Direccion { get; set; }

        [MaxLength(40)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Genero es requerido")]
        [StringLength(1, ErrorMessage = "Genero debe ser Minimo 1 Maximo 1 caracteres")]
        public char Genero { get; set; }

        [Required(ErrorMessage = "Especialidad es requerida")]
        public int EspecialidadId { get; set; }

        [ForeignKey("EspecialidadId")]
        public Especialidad Especialidad { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }


    }
}
