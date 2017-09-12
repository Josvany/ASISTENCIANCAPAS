using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using BLL;

namespace AsistenciaMVCUI.Controllers
{
    public class TasaCambioController : Controller
    {
        // GET: TasaCambio
        public ActionResult Index()
        {

            var tblTasaCambio = from t in TasaCambioBLL.ObtenerTasaCambio()
                                orderby t.Fecha
                                select t;

            return View(tblTasaCambio.ToList());
        }
    }
}