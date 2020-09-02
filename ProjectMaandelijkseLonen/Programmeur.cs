using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLonen
{
    public class Programmeur : Werknemers
    {
        //public bool BedrijfWagen { get; set; }
        public Programmeur(string naam, string geslacht, DateTime startTime, string iban, DateTime geboortDatum, string rijksRegNum, double startloon = 2200, Funkcie work = Funkcie.Programmeur, int uuren = 38, ConractType conractType = ConractType.Voltijds, bool bedrijfWagen=false) : base(naam,geslacht, startTime, iban, geboortDatum, rijksRegNum,startloon, work, uuren, conractType, bedrijfWagen)
        {
            //BedrijfWagen = bedrijfWagen;
            
        }
       
    }
}
