using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Entity
{
   public class EmpleadosEntity
    {
        public EmpleadosEntity()
        {
            DepartamentoEntity = new DepartamentoEntity();
            TurnosEntity = new TurnosEntity();
        }
        public int IdEmpleados { get; set; }

        [Required (ErrorMessage ="Nombre del Empleado no puede ser vacio")]
        [StringLength (100)]
        public string Nombres { get; set; }

        public bool Activo { get; set; }
        [Required(ErrorMessage = "Debe Seleccionar Departamento")]
        public int IdDepartamento { get; set; }

        public string Departamento { get; set; }

        [Required(ErrorMessage = "Debe Seleccionar Turno")]

         public int IdTurno { get; set; }

        public string Turno { get; set; }

        [Required(ErrorMessage = "Salario debe ser mayor que cero")]
        //[Range(typeof(double), "4700.00", "250000.00")]
        public double Salario { get; set; }

        [Required(ErrorMessage = "Dia Libre No puede ser vacio")]
        public string DiaLibre { get; set; }

        public DepartamentoEntity DepartamentoEntity { get; set; }
        public TurnosEntity TurnosEntity { get; set; }


    }
}
