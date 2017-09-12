using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
  public  class EmpleadosBLL
    {
        public static List<EmpleadosEntity> Listar()
        {
            return EmpleadosDAL.Listar();
        }
        public static EmpleadosEntity Obtener(int IdEmpleados)
        {
            return EmpleadosDAL.Obtener(IdEmpleados);
        }
        public static bool Insertar(EmpleadosEntity oEmpleadosEntity)
        {
            return EmpleadosDAL.Insertar(oEmpleadosEntity);
        }
        public static bool Actualizar(EmpleadosEntity oEmpleadosEntity)
        {
            return EmpleadosDAL.Actualizar(oEmpleadosEntity);
        }



    }
}
