using System;
using System.ComponentModel.DataAnnotations;

namespace SifAdmin.Areas.Departamento.Models
{
    public class Departamentos
    {
        [Key]
        public string Codigo_Departamento { get; set; }
        public string Nombre_Departamento { get; set; }
    }
}