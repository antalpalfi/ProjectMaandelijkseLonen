using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLonen
{
    public class Support : Werknemers
    {
        // 2 dagen thuis werken
        // 50 euro plusz elke mand
        public Support(string naam, string geslacht, DateTime startTime, string iban, DateTime geboortDatum, string rijksRegNum, double startloon = 2050, Funkcie work = Funkcie.Support, int uuren = 38, ConractType conractType = ConractType.Voltijds) : base(naam,geslacht, startTime, iban, geboortDatum, rijksRegNum,startloon, work, uuren, conractType)
        {
        }
        public  double NettoSupport()
        {
            double money = GeneretAncientSocial();
            double netto = money - (money * 0.1368)+50;
            return Math.Round(netto, 2);
        }
    }
}
