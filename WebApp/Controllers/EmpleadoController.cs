using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            List<EmpleadoCLS> listaEmpleado = null;
            using (var bd= new BDWebAppEntities())
            {
                listaEmpleado = (from empleado in bd.Empleado
                                 join tipousuario in bd.TipoUsuario
                                 on empleado.IIDTIPOUSUARIO equals tipousuario.IIDTIPOUSUARIO
                                 join TipoContrato in bd.TipoContrato
                                 on empleado.IIDTIPOCONTRATO equals TipoContrato.IIDTIPOCONTRATO
                                 select new EmpleadoCLS
                                 {
                                     iidEmpleado = empleado.IIDEMPLEADO,
                                     nombre =  empleado.NOMBRE,
                                     apPaterno =  empleado.APPATERNO,
                                     nombreTipoUsuario = tipousuario.NOMBRE,
                                     nombreTipoContrato = TipoContrato.NOMBRE

                                 }).ToList();


            }
            return View(listaEmpleado);
        }
    }
}