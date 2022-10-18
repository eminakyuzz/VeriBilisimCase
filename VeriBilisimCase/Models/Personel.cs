using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VeriBilisimCase.Models
{
    public class Personel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string PersonelAd { get; set; }
        [Required]
        public string PersonelSoyad { get; set; }
        public IL IL { get; set; }
        public Ilce Ilce { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime  DogumTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}
