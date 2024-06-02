using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//para usar "DataAnnotations"
using System.ComponentModel.DataAnnotations;

namespace ClinicaParavida.Models
{
    public class Enfermera
    {
        //Definimos los atributos 
        [Key]
        [Display(Name = "Codigo de Enfermera")]
        [Required(ErrorMessage = "El codigo es obligatorio")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "El codigo debe tener 6 Caracteres")]
        public string CodigoEnfermera { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El Nombre debe tener entre 3 y 50 caracteres")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El Apellido debe tener entre 3 y 50 caracteres")]

        public string Apellidos { get; set; }
        [Display(Name = "No. DUI")]
        [Required(ErrorMessage = "El No. DUI es obligatorio")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El DUI debe tener 10 caracteres")]
        public string Dui { get; set; }
        [Display(Name = "Doctor")]
        [Required(ErrorMessage = "El Doctor es obligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El de Doctor debe tener entre 3 y 50 caracteres")]
        public string Doctor { get; set; }

        [Display(Name = "Hora de la Cita")]
        [Required(ErrorMessage = "La Hora de la Cita es obligatoria")]
        [DataType(DataType.Time, ErrorMessage = "El formato de la Hora de la Cita no es válido")]
        public DateTime Hora { get; set; }
        [Display(Name = "Fecha de la Cita")]
        [Required(ErrorMessage = "La Fecha de la Cita es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "El formato de la Fecha de la Cita no es válido")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Estado de la Cita")]
        [Required(ErrorMessage = "El Estado de la Cita es obligatorio")]
        public EstadoCita Estado { get; set; }
    }

    public enum EstadoCita
    {
        Pendiente,
        Denegada,
        Aceptada
    }

}
