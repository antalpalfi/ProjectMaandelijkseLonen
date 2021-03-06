﻿using System;
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
        public double Uuren { get; set; }
        public bool BedrijfWagen { get; set; }
        public double Netto { get; set; }
        public string Geslagh { get; set; }
        public double SixExtra { get; set; }
        public enum Funkcie
        {
            Standaardwerker,Programmeur,Support,ITsupport,Customersupport
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
        public Werknemers(string naam, string geslacht,DateTime startTime,string iban,DateTime geboortDatum,string rijksRegNum,double startloon = 1900,Funkcie work = Funkcie.Standaardwerker, double uuren = 38, ConractType conractType = ConractType.Voltijds,bool bedrijfWagen =false)
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
        }
        public double StartMoney()
        {
            double sixExtra;
            double StartMoney;
            double itStartLoon = Startloon;
            if (Work.ToString() == "ITsupport")
            {
                sixExtra = Startloon * 0.06;
                itStartLoon = Startloon - sixExtra;
                StartMoney = Uuren / 38 * itStartLoon;
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
                return Math.Round(loonMetAncEnSoc, 2);
            }
            else
            for (int i = 0; i < dientsJaar; i++)
            {
                loonMetAncEnSoc *= 1.01;
            }
            return Math.Round(loonMetAncEnSoc, 2);
        }
        public double SocialZekeheid()
        {
            double loonMetAc = GeneretAncientSocial();
            double loonMetSocZek = loonMetAc - 200;
            return Math.Round(loonMetSocZek,2);
        }
        public double NettoLoon()
        {
            double money;
            double netto;
            if (BedrijfWagen==true)
            {
                money = SocialZekeheid();
                netto = money - (money * 0.1730);
                return Math.Round(netto, 2);
            }
            else if (Work.ToString() == "Support")
            {
                money = SocialZekeheid();
                netto = money - (money * 0.1368) + 50;
                return Math.Round(netto, 2);
            }
            else if (Work.ToString() == "Customersupport")
            {
                money = SocialZekeheid();
                netto = money - (money * 0.1368) +19.50;
                return Math.Round(netto, 2);
            }
            else
            {
                money = SocialZekeheid();
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
                   $"Contract: {TypeOfContract}\n"+
                   $"Startloon: {Startloon}$\n" +
                   $"Nettoloon: {Netto}$\n";
        }

        public override string ToString()
        {
            return Naam;
        }

    }
   
}
