using System;
using System.ComponentModel.DataAnnotations;

namespace SifAdmin.Areas.Departamento.Models
{
    public class Departamentos
    {
        [Key]
        [Required]
        [Display(Name = "Codigo")]
        public string Codigo_Departamento { get; set; }

        [Required]
        [Display(Name = "Nombre DePartamento")]
        public string Nombre_Departamento { get; set; }
    }
}