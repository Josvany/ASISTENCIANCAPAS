using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Ofn;


namespace DAL
{
   public class TurnosDAL
    {

        public static List<TurnosEntity> Listar()
        {
            var oTurnosEntity = new List<TurnosEntity>();
            try
            {
                var dt = fn.Leer("Usp_ListarTurnos");
                for (int i = 0; i <= dt.Rows.Count-1; i++)
                {
                    oTurnosEntity.Add(new TurnosEntity
                    {
                        IdTurno = (int)dt.Rows[i][0],
                        Turno = dt.Rows[i][1].ToString()
                    });
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return oTurnosEntity;

        }


    }
}
