using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _13132_egzamin_z_asp.net.Models
{
    public class Awaria
    {
        [HiddenInput]
        public int AwariaID { get; set; }
        [Required]
        public string miejsce { get; set; }

        public string opis { get; set; }

        [Required]
        [Range(1, 100)]
        public int nrUrzadzenia { get; set; }

        public DateTime dataZgloszenia { get; set; }

    }
}
