using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSeeker.Models
{
    public class RegisterFizickoLiceModelcs
    {
        [Key]
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRođenja { get; set; }
        public string Iskustvo { get; set; }
        public string KratkaBiografija { get; set; }
        public string Djelatnost { get; set; }
        [NotMapped]
        public DateTime DatumKreiranjaProfila { get; set; }
        [NotMapped]
        public DateTime DatumVerifikacije { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string ListaOglasa { get; set; }
    }
}
