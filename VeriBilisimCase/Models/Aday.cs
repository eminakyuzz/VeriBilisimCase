using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeriBilisimCase.Models
{
    public class Aday
    {
        [Key]
        public int AdayID { get; set; }
        public string AdayAdi { get; set; }
        public string AdaySoyadi { get; set; }
        public DateTime BasvuruTarihi { get; set; }
        public IL IL { get; set; }
        public Ilce Ilce { get; set; }
        public bool SeyahatEngeli { get; set; }
        public string IsyeriAdi { get; set; }
        public string Pozisyon { get; set; }
        public string Aciklama { get; set; }

    }
}
