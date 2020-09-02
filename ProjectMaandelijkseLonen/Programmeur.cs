using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLonen
{
    public class Programmeur : Werknemers
    {
        public bool BedrijfWagen { get; set; }
        public Programmeur(string naam, string geslacht, DateTime startTime, string iban, DateTime geboortDatum, string rijksRegNum, double startloon = 2200, Funkcie work = Funkcie.Programmeur, bool bedrijfWagen = true, int uuren = 38, ConractType conractType = ConractType.Voltijds) : base(naam,geslacht, startTime, iban, geboortDatum, rijksRegNum,startloon, work, uuren, conractType)
        {
            BedrijfWagen = bedrijfWagen;
            //BedrijfsVoorheffing = (bedrijfWagen == true ? 17.30 : 13.68);
        }
        public double ProgNetto()
        {
            double money = GeneretAncientSocial();
            double netto = money - (money * 0.1730);
            return Math.Round(netto, 2);
        }
    }
}
