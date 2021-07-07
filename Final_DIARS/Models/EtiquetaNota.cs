using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_DIARS.Models
{
    public class EtiquetaNota
    {
        public int Id { get; set; }
        public int IdEtiqueta { get; set; }
        public int IdNota { get; set; }
        public Etiqueta Etiqueta { get; set; }

    }
}
