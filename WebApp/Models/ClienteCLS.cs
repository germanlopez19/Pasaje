using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class ClienteCLS
    {
        [Display(Name="Id Cliente")]
        public int iidcliente { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        [StringLength(100,ErrorMessage ="Longitud maxima de 100")]
        public string nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        [Required]
        [StringLength(150, ErrorMessage = "Longitud maxima de 150")]
        public string apPaterno { get; set; }
        [Display(Name = "Apellido Materno")]
        [Required]
        [StringLength(150, ErrorMessage = "Longitud maxima de 150")]
        public string apMaterno { get; set; }
        [Display(Name = "Email")]
        [StringLength(200, ErrorMessage = "Longitud maxima de 200")]
        [Required]
        [EmailAddress(ErrorMessage ="Ingresa un email válido")]
        public string email { get; set; }
        [Display(Name = "Direccion")]
        [Required]
        [StringLength(200, ErrorMessage = "Longitud maxima de 200")]

        public string direccion { get; set; }
        [Display(Name = "Id Sexo")]
        public int iidsexo { get; set; }
        [Display(Name = "Telefono Fijo")]
        [Required]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        public string telefonoFijo { get; set; }
        [Display(Name = "Telefono Celular")]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10")]
        [Required]
        public string telefoCelular { get; set; }
        //public int bhabilitado { get; set; }
        //public int bTieneUsuario { get; set; }
        //[Display(Name = "Tipo Usuario")]
        //public string tipoUsuario { get; set; }
    }
}