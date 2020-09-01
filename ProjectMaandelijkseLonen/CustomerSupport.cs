using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLonen
{
    public class CustomerSupport : Support
    {
        // elke maand 19.50euro opleiding => na het bedrijfsvoorheffing terug betald
        public CustomerSupport(string naam, DateTime startTime, string iban, DateTime geboortDatum, string rijksRegNum, double netto, double startloon = 2050, Funkcie work = Funkcie.Support, int uuren = 38, ConractType conractType = ConractType.Voltijds) : base(naam, startTime, iban, geboortDatum, rijksRegNum, netto, startloon, work, uuren, conractType)
        {

        }
    }
}
