using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_DIARS.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Password { get; set; }
    }
}
