using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//para usar "DataAnnotations"
using System.ComponentModel.DataAnnotations;

namespace ClinicaParavida.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "El codigo debe tener 6 Caracteres")]
        public string IdUsuario { get; set; }

        [Required(ErrorMessage = "El Usuario es obligatorio")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "El Usuario debe tener entre 10 y 15 caracteres")]
        public string User { get; set; }

        [Required(ErrorMessage = "La Clave es obligatoria")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "La Clave debe tener entre 10 y 15 caracteres")]
        public string Clave  { get; set; }


        [Required(ErrorMessage = "La  confirmacion de laClave es obligatoria")]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "La Clave debe tener entre 10 y 15 caracteres")]
        public string ConfirmarClave {  get; set; }
    }
}