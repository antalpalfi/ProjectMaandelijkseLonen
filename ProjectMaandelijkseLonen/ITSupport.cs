using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLonen
{
    public class ITSupport : Support
    {
        // moet 38uur werken / week
        // geen deeltijds contract
        // 6% afgetrokken van ancienniteit dan terug betald
        public ITSupport(string naam, string geslacht, DateTime startTime, string iban, DateTime geboortDatum, string rijksRegNum, double startloon = 2050, Funkcie work = Funkcie.Support, int uuren = 38, ConractType conractType = ConractType.Voltijds) : base(naam, geslacht, startTime, iban, geboortDatum, rijksRegNum,startloon, work, uuren, conractType)
        {
           
        }
        
    }
}
