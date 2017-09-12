using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Ofn;


namespace DAL
{
    public class DepartamentoDAL
    {
        
        public static List<DepartamentoEntity> Listar()
        {
            var oDepartamentoEntity = new List<DepartamentoEntity>();
            try
            {
                var dt = fn.Leer("Usp_ListarDepartamento");
                for (int i=0;i<=dt.Rows.Count-1; i++)
                {
                    oDepartamentoEntity.Add(new DepartamentoEntity
                    {
                        IdDepartamento = (int)dt.Rows[i][0],
                        Departamento = dt.Rows[i][1].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return oDepartamentoEntity;

        }

    }
}
