using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class DepartamentoEntity
    {
        public int IdDepartamento { get; set; }
        [Required (ErrorMessage ="Departamento no puede ser vacio")]
        [StringLength(75)]
        public string Departamento { get; set; }
    }
}
