using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSeeker.Models
{
    public class OglasModel
    {
        public int ID { get; set; }
        public string NazivOglasa { get; set; }
        public string OpisOglasa { get; set; }
        public string Lokacija { get; set; }
        public int BrojIzvršilaca { get; set; }
        public string TipOglasa { get; set; }
        public DateTime DatumObjaveOglasa { get; set; }
        public int TrajanjeOglasa { get; set; }
        public DateTime DatumModifikacije { get; set; }
        public int BrojPrijavljenih { get; set; }
    }
}
