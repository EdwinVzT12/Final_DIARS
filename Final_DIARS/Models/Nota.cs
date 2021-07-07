using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_DIARS.Models
{
    public class Nota
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Contenido { get; set; }
    }
}
