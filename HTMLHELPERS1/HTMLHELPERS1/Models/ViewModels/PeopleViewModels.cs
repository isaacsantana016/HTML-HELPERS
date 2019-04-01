using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HTMLHELPERS1.Models.ViewModels
{
    public class PeopleViewModels
    {
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        [Range(15, 100, ErrorMessage = "Debe ser mayor de 15 año")]
        public int Edad { get; set; }
        public string Telefono { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [UIHint("DropDownList")]

        public string Genero { get; set; }


        public bool Pescar { get; set; }
        public bool Bailar { get; set; }
        public bool Video_juego { get; set; }
        public bool Leer { get; set; }





    }
}