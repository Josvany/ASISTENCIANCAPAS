using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity;
using BLL;

namespace AsistenciaMVCUI.Controllers
{
    public class EmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            return View(EmpleadosBLL.Listar());
        }

        public ActionResult Guardar(EmpleadosEntity oEmpleadosEntity)
        {
            var SituboExito = oEmpleadosEntity.IdEmpleados > 0 ? EmpleadosBLL.Actualizar(oEmpleadosEntity) :
                                                               EmpleadosBLL.Insertar(oEmpleadosEntity);
            if (!SituboExito)
            {
                ViewBag.Mensaje = "Error al Grabar Favor Revisar";
                return View("~/Views/Shared/Error.cshtml");
            }

            return Redirect("~/Empleados/Index");
        }

        public ActionResult Editar (int IdEmpleados =0)
        {

            ViewBag.Departamento = DepartamentoBLL.Listar();
            ViewBag.Turno = TurnosBLL.Listar();
            return View(IdEmpleados == 0 ?
            new EmpleadosEntity() :
            EmpleadosBLL.Obtener(IdEmpleados));

        }


        //public ActionResult Report(string id)
        //{
        //    LocalReport lr = new LocalReport();
        //    string path = Path.Combine(Server.MapPath("~/Reportes"), "RptListadoDepartamentos.rdlc");
        //    if (System.IO.File.Exists(path))
        //    {
        //        lr.ReportPath = path;
        //    }
        //    else
        //    {
        //        return View("Index");
        //    }
        //    List<tblDepartamento> cm = new List<tblDepartamento>();
        //    using (BDAsistenciaMVCEntities dc = new BDAsistenciaMVCEntities())
        //    {
        //        cm = dc.tblDepartamento.ToList();
        //    }
        //    ReportDataSource rd = new ReportDataSource("ds", cm);
        //    lr.DataSources.Add(rd);
        //    string reportType = id;
        //    string mimeType;
        //    string encoding;
        //    string fileNameExtension;



        //    string deviceInfo =

        //    "<DeviceInfo>" +
        //    "  <OutputFormat>" + id + "</OutputFormat>" +
        //    "  <PageWidth>8.5in</PageWidth>" +
        //    "  <PageHeight>11in</PageHeight>" +
        //    "  <MarginTop>0.5in</MarginTop>" +
        //    "  <MarginLeft>1in</MarginLeft>" +
        //    "  <MarginRight>1in</MarginRight>" +
        //    "  <MarginBottom>0.5in</MarginBottom>" +
        //    "</DeviceInfo>";

        //    Warning[] warnings;
        //    string[] streams;
        //    byte[] renderedBytes;

        //    renderedBytes = lr.Render(
        //        reportType,
        //        deviceInfo,
        //        out mimeType,
        //        out encoding,
        //        out fileNameExtension,
        //        out streams,
        //        out warnings);


        //    return File(renderedBytes, mimeType);
        //}


    }
}