using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMaandelijkseLonen
{
    public class Werknemers
    {
        public string Naam { get; set; }
        public DateTime StartTime { get; set; }
        public string Iban { get; set; }
        public DateTime GeboortDatum { get; set; }
        public string RijkRegNum { get; set; }
        public double Startloon { get; set; }
        public double Netto { get; set; }
        public string Geslagh { get; set; }

        //public double BedrijfsVoorheffing = 13.68;

        public int Uuren { get; set; }
        public enum Funkcie
        {
            Baliemedewerker,Kuisploeg,Programmeur,Support,ITsupport,Customersupport
        }
        public Funkcie Work;
        public enum ConractType
        {
            Voltijds,Deeltijds
        }
        public ConractType TypeOfContract;
        public Werknemers()
        {

        }

       
        public Werknemers(string naam, string geslacht,DateTime startTime,string iban,DateTime geboortDatum,string rijksRegNum,double startloon = 1900,Funkcie work = Funkcie.Baliemedewerker, int uuren = 38, ConractType conractType = ConractType.Voltijds)
        {
            Naam = naam;
            Geslagh = geslacht;
            StartTime = startTime;
            GeboortDatum = geboortDatum;
            Iban = iban;
            RijkRegNum = rijksRegNum;
            Netto = NettoLoon();
            Startloon = startloon;
            TypeOfContract = conractType;
            Uuren = uuren;
            Work = work;
            //TimeSpan different = DateTime.Now - startTime;
        }
        private double StartMoney()
        {
            double StartMoney = Uuren/ 38 * Startloon;
            return Math.Round(StartMoney, 2);
        }
        public double GeneretAncientSocial()
        {
            int dientsJaar = DateTime.Now.Year - StartTime.Year;
            double loonMetAncEnSoc = StartMoney();
            for (int i = 0; i < dientsJaar; i++)
            {
                loonMetAncEnSoc *= 1.01;
            }
            loonMetAncEnSoc -= 200;
            return Math.Round(loonMetAncEnSoc, 2);

        }
        public  virtual double NettoLoon()
        {
            double money = GeneretAncientSocial();
            double netto = money - (money * 0.1368);
            return Math.Round(netto, 2);
        }
       
        public virtual string WerknemInfo()
        {
            return $"Rijkregisternummer: {RijkRegNum}\n" +
                   $"Iban nummer: {Iban}\n"+
                   $"Geslacht: {Geslagh}\n" +
                   $"Geboortedatum: {GeboortDatum:dd/MM/yyyy}\n" +
                   $"Datum indiensttreding: {StartTime:dd/MM/yyyy}\n" +
                   $"Functie: {Work}\n" +
                   $"Aantal uren: {Uuren}\n" +
                   $"Startloon: {Startloon}\n" +
                   $"Nettoloon: {Netto}\n";
        }

        public override string ToString()
        {
            return Naam;
        }

    }
   
}
