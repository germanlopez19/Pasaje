using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class BusCLS
    {
        [Display(Name="IdBus")]
        public int iidBus { get; set; }
        [Display(Name ="Nombre Sucursal")]
        [Required]
        public int iidSucursal { get; set; }
        [Display(Name = "Tipo Bus")]
        [Required]
        public int iidTipoBus { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Compra")]
        public DateTime fechaCompra { get; set; }
        [Display(Name = "Nombre Modelo")]
        [Required]
        public int iidModelo { get; set; }
        [Display(Name = "Numero de filas")]
        [Required]
        public int numeroFilas { get; set; }
        [Display(Name = "Numero de columnas")]
        [Required]
        public int numeroColumnas { get; set; }
        [Display(Name = "Descripcion")]
        [Required]
        [StringLength(200,ErrorMessage ="La longitud máxima es de 200")]
        public string descripcion { get; set; }
        [Display(Name = "Observacion")]
        [StringLength(200,ErrorMessage ="La longitud máxima es de 200")]
        public string observacion { get; set; }
        [Display(Name = "Nombre Marca")]
        [Required]
        public int iidmarca { get; set; }

        //Propiedades Adicionales
        [Display(Name = "Nombre Sucursal")]
        public string nombreSucursal { get; set; }
        [Display(Name = "Nombre Bus")]
        public string nombreTipoBus { get; set; }
    }
}