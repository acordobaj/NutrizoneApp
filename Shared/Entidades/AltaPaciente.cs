using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NutrizoneApp.Shared.Entidades
{
    public class AltaPaciente
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        public string Nombre { get; set; }
        [Required (ErrorMessage = "El campo Peso es Requerido")]
        public string Peso { get; set; }
        [Required(ErrorMessage = "El campo Edad es Requerido")]
        public string Edad { get; set; }
        [Required(ErrorMessage = "El campo Talla es Requerido")]
        public string Talla { get; set; }


    }
}
