using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Ofn;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
   public class EmpleadosDAL
    {

        public static List<EmpleadosEntity> Listar()
        {
            var oEmpleadosEntity = new List<EmpleadosEntity>();
            try
            {
                var dt = fn.Leer("Usp_ListarEmpleados");
                for (int i = 0; i <= dt.Rows.Count-1; i++)
                {
                    oEmpleadosEntity.Add(new EmpleadosEntity
                    {
                        IdEmpleados = (int)dt.Rows[i][0],
                         Nombres = dt.Rows[i][1].ToString(),
                         Activo = (bool)dt.Rows[i][2],
                         IdDepartamento = (int)dt.Rows[i][3],
                         IdTurno = (int)dt.Rows[i][4],
                         Salario= (double)dt.Rows[i][5],
                         DiaLibre = dt.Rows[i][6].ToString(),
                         Departamento=dt.Rows[i]["Departamento"].ToString(),
                         Turno= dt.Rows[i]["Turno"].ToString(),

                    });
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return oEmpleadosEntity;

        }

        public static EmpleadosEntity Obtener (int IdEmpleados)
        {
            var oEmpleadosEntity = new EmpleadosEntity();
            try
            {             
            var dt = fn.Leer("Usp_ObtenerEmpleados", IdEmpleados);
            if (dt.Rows.Count>0)
            {
                oEmpleadosEntity.IdEmpleados = (int)dt.Rows[0][0];
                oEmpleadosEntity.Nombres = dt.Rows[0][1].ToString();
                oEmpleadosEntity.Activo = (bool)dt.Rows[0][2];
                oEmpleadosEntity.IdDepartamento = (int)dt.Rows[0][3];
                oEmpleadosEntity.IdTurno = (int)dt.Rows[0][4];
                oEmpleadosEntity.Salario = (double)dt.Rows[0][5];
                oEmpleadosEntity.DiaLibre = dt.Rows[0][6].ToString();
                oEmpleadosEntity.Departamento = dt.Rows[0]["Departamento"].ToString();
                oEmpleadosEntity.Turno = dt.Rows[0]["Turno"].ToString();
            }
            }
            catch (Exception e)
            {
                throw;
            }
            return oEmpleadosEntity;
        }

        public static bool Insertar (EmpleadosEntity oEmpleadosEntity)
        {
            bool SituboExito = false;
            try
            {
                using (var cn = fn.GetConnection())
                {
                    cn.Open();                   

                    var Sql = new SqlCommand("Usp_InsertEmpleados", cn);
                    Sql.CommandType = CommandType.StoredProcedure;
                    Sql.Parameters.AddWithValue("@Nombres", oEmpleadosEntity.Nombres);
                    Sql.Parameters.AddWithValue("@Activo", oEmpleadosEntity.Activo);
                    Sql.Parameters.AddWithValue("@IdDepartamento", oEmpleadosEntity.IdDepartamento);
                    Sql.Parameters.AddWithValue("@IdTurno", oEmpleadosEntity.IdTurno);
                    Sql.Parameters.AddWithValue("@Salario", oEmpleadosEntity.Salario);
                    Sql.Parameters.AddWithValue("@DiaLibre", oEmpleadosEntity.DiaLibre);
                    Sql.ExecuteNonQuery();
                    SituboExito = true;
                }
            }
            catch (Exception e)
            {
                SituboExito = false;
            }
            return SituboExito;
        }


        public static bool Actualizar(EmpleadosEntity oEmpleadosEntity)
        {
            bool SituboExito = false;
            try
            {
                using (var cn = fn.GetConnection())
                {
                    cn.Open();

                    SituboExito= fn.Guardar("Usp_UpdateEmpleados", oEmpleadosEntity.IdEmpleados,
                                                                   oEmpleadosEntity.Nombres,
                                                                   oEmpleadosEntity.Activo,
                                                                   oEmpleadosEntity.IdDepartamento,
                                                                   oEmpleadosEntity.IdTurno,
                                                                   oEmpleadosEntity.Salario,
                                                                   oEmpleadosEntity.DiaLibre);            
                    
                }
            }
            catch (Exception e)
            {
                SituboExito = false;
            }
            return SituboExito;
        }


    }
}
