using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SifAdmin.Areas.Departamento.Models
{
    public class DepartamentoModel
    {
        [Key]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name ="Codigo")]
        [StringLength(maximumLength:2,MinimumLength =2,ErrorMessage ="Se Requieroe Un Digito de Dos Sifras")]
        public string Codigo_Departamento { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nombre Departamento")]
        [StringLength(maximumLength:50, MinimumLength = 2)]
        public string Nombre_Departamento { get; set; }
    }
}
