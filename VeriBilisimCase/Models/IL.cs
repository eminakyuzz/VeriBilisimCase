using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeriBilisimCase.Models
{
    public class IL
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Ad { get; set; }
    }
}
