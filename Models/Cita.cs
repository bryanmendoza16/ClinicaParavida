﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//para usar "DataAnnotations"
using System.ComponentModel.DataAnnotations;

namespace ClinicaParavida.Models
{
    public class Cita
    {
        [Key]
        [Display(Name = " Id de Citas")]
        [Required(ErrorMessage = "El codigo es obligatorio")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "El codigo debe tener 6 Caracteres")]
        public string CitasID { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "El nombre debe tener  debe tener 8 Caracteres al menos. ")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "El apellido debe tener  debe tener 8 Caracteres al menos.")]
        public string Apellido {  get; set; }
        [Required(ErrorMessage = "El Dui es obligatorio")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El Dui debe tener  debe tener 10 Caracteres")]
        public string PacienteDUI { get; set;}
        [Required(ErrorMessage = "El doctor es obligatorio")]
       
        public string Doctor { get; set;}
        [Display(Name = "Hora de la Cita")]
        [Required(ErrorMessage = "La Hora de la Cita es obligatoria")]
        [DataType(DataType.Time, ErrorMessage = "El formato de la Hora de la Cita no es válido")]
        public DateTime Hora { get; set; }
        [Display(Name = "Fecha de la Cita")]
        [Required(ErrorMessage = "La Fecha de la Cita es obligatoria")]
        [DataType(DataType.Date, ErrorMessage = "El formato de la Fecha de la Cita no es válido")]
        public DateTime Fecha { get; set; }

    }
}