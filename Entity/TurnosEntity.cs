using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class TurnosEntity
    {
        public int IdTurno { get; set; }
        [Required(ErrorMessage = "Turno no puede ser vacio")]
        [StringLength(75)]
        public string Turno { get; set; }

    }
}
