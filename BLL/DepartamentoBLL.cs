using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class DepartamentoBLL
    {
       public static List<DepartamentoEntity> Listar()
        {           
            return DepartamentoDAL.Listar();
        }

    }
}
