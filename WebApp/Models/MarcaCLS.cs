using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class MarcaCLS
    {
        [Display(Name="Id Marca")]
        public int iidmarca { get; set; }
        [Required]
        [Display (Name = "Nombre marca")]
        [StringLength(100, ErrorMessage ="La longitud maxima es 100")]
        public string nombre { get; set; }
        [Display(Name = "Descripcion marca")]
        [Required]
        public string descripcion { get; set; }
        public int bhabilitado { get; set; }
    }
}