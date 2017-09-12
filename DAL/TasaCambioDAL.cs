using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using DAL.WSTasaDeCambio;
using System.Xml;
using System.Web;
using System.Xml.Linq;

namespace DAL
{
  public  class TasaCambioDAL
    {
        public static IEnumerable<TasaCambioEntity> ObtenerTasaCambio()
        {
            using (WSTasaDeCambio.Tipo_Cambio_BCNSoapClient TipoCambio
                = new Tipo_Cambio_BCNSoapClient())
            {

                var TasaCambio =
                TipoCambio.RecuperaTC_Mes(DateTime.Today.Year, DateTime.Today.Month);
                var TablaTasacambio = TasaCambio.Elements().Select(X => new TasaCambioEntity
                {
                    Fecha = DateTime.Parse(X.Element("Fecha").Value),
                    Valor = (X.Element("Valor").Value.ToString())
                }
                ).ToArray();
                return TablaTasacambio;
            }


        }



    }
}
