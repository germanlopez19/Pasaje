using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class SucursalCLS
    {
        [Display(Name = "ID Sucursal")]
        public int iidsucursal { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        [StringLength(100, ErrorMessage = "La longitud máxima es de 100")]
        public string nombre { get; set; }
        [Display(Name = "Dirección")]
        [Required]
        [StringLength(200, ErrorMessage = "La longitud máxima es de 200")]
        public string direccion { get; set; }
        [Display(Name = "Telefono")]
        [Required]
        [StringLength(10, ErrorMessage = "La longitud máxima es de 10 digitos")]
        public string telefono { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress(ErrorMessage ="Ingrese un email válido")]
        public string email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Fecha Apertura")]
        [Required]
        public DateTime fechaapertura { get; set; }
        
        public int bhabilitado { get; set; }

    }
}