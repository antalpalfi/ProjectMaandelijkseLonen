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
        public int Uuren { get; set; }
        public bool BedrijfWagen { get; set; }
        public double Netto { get; set; }
        public string Geslagh { get; set; }
        public double SixExtra { get; set; }

        //public double BedrijfsVoorheffing = 13.68;

       
        public enum Funkcie
        {
            Baliemedewerker,Programmeur,Support,ITsupport,Customersupport
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

       
        public Werknemers(string naam, string geslacht,DateTime startTime,string iban,DateTime geboortDatum,string rijksRegNum,double startloon = 1900,Funkcie work = Funkcie.Baliemedewerker, int uuren = 38, ConractType conractType = ConractType.Voltijds,bool bedrijfWagen =false)
        {
            Naam = naam;
            Geslagh = geslacht;
            StartTime = startTime;
            GeboortDatum = geboortDatum;
            Uuren = uuren;
            Iban = iban;
            RijkRegNum = rijksRegNum;
            Startloon = startloon;
            BedrijfWagen = bedrijfWagen;
            TypeOfContract = conractType;
            Work = work;
            Netto = NettoLoon();
            //TimeSpan different = DateTime.Now - startTime;
        }
        private double StartMoney()
        {
            double sixExtra;
            double StartMoney;
            if (Work.ToString() == "ITsupport")
            {
                sixExtra = Startloon * 0.06;
                Startloon = Startloon - sixExtra;
                StartMoney = Uuren / 38 * Startloon;
                SixExtra = sixExtra;
                return Math.Round(StartMoney, 2);
            }
            else
           
            StartMoney = Uuren/ 38 * Startloon;
            return Math.Round(StartMoney, 2);
        }
        public double GeneretAncientSocial()
        {
            int dientsJaar = DateTime.Now.Year - StartTime.Year;
            double loonMetAncEnSoc = StartMoney();
            if (Work.ToString() == "ITsupport")
            {
                for (int i = 0; i < dientsJaar; i++)
                {
                    loonMetAncEnSoc *= 1.01;
                }
                loonMetAncEnSoc += SixExtra;
                loonMetAncEnSoc -= 200;
                return Math.Round(loonMetAncEnSoc, 2);
            }
            else
            for (int i = 0; i < dientsJaar; i++)
            {
                loonMetAncEnSoc *= 1.01;
            }
            loonMetAncEnSoc -= 200;
            return Math.Round(loonMetAncEnSoc, 2);

        }
        //public   double NettoLoon()
        //{
        //    double money = GeneretAncientSocial();
        //    double netto = money - (money * 0.1368);
        //    return Math.Round(netto, 2);
        //}
        public double NettoLoon()
        {
            double money;
            double netto;
            if (BedrijfWagen==true)
            {
                money = GeneretAncientSocial();
                netto = money - (money * 0.1730);
                return Math.Round(netto, 2);
            }
            else if (Work.ToString() == "Support")
            {
                money = GeneretAncientSocial();
                netto = money - (money * 0.1368) + 50;
                return Math.Round(netto, 2);
            }
            else if (Work.ToString() == "Customersupport")
            {
                money = GeneretAncientSocial();
                netto = money - (money * 0.1368) +19.50;
                return Math.Round(netto, 2);
            }
            else
            {
                money = GeneretAncientSocial();
                netto = money - (money * 0.1368);
                return Math.Round(netto, 2);
            }
            
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
