﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
   public class TurnosBLL
    {
        public static List<TurnosEntity> Listar()
        {
            return TurnosDAL.Listar();
        }
    }
}
