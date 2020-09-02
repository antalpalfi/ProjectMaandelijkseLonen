using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMaandelijkseLonen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Werknemers> werknemersList = new List<Werknemers>();
        //Werknemers getWerk = new Werknemers();
        private void Form1_Load(object sender, EventArgs e)
        {
            Werknemers antal = new Werknemers("Antal Palfi","Man", new DateTime(2018,06,13), "Be 1235 1532 1654", new DateTime(1990,06,16), "164598-184-16-06-1990",1900,work: Werknemers.Funkcie.Standaardwerker, 38, conractType: Werknemers.ConractType.Deeltijds);
            werknemersList.Add(antal);
            Werknemers tomi = new Werknemers("Tomi Palfi","Man" ,new DateTime(2015, 06, 13), "Be 1235 1532 1654", new DateTime(1995, 07, 26), "168898-184-26-07-1995",2200,work:Werknemers.Funkcie.Programmeur ,38, conractType: Werknemers.ConractType.Voltijds,true);
            werknemersList.Add(tomi);
            Werknemers eszti = new Werknemers("Eszter Boer", "Vrouw", new DateTime(2008, 01, 23), "NL 1235 1532 7854", new DateTime(1978, 04, 11), "168898-184-11-04-1978", 2050, work: Werknemers.Funkcie.Support, 38, conractType: Werknemers.ConractType.Voltijds);
            werknemersList.Add(eszti);
            Werknemers kriszti = new Werknemers("Krisztina Vigh", "Vrouw", new DateTime(2010, 01, 23), "NL 6535 15892 7854", new DateTime(1985, 04, 18), "174898-184-18-04-1985", 2050, work: Werknemers.Funkcie.ITsupport, 38, conractType: Werknemers.ConractType.Voltijds);
            werknemersList.Add(kriszti);
            listBox1.DataSource = null;
            listBox1.DataSource = werknemersList;
            //label1.Text = getWerk.WerknemInfo();
            //getWerk.NettoLoon(); 
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.DataSource!=null)
            {
                label1.Text = (listBox1.SelectedItem as Werknemers).WerknemInfo();
            }
            else
            {
                label1.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
                werknemersList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedIndex);
                listBox1.DataSource = null;
                listBox1.DataSource = werknemersList;
           
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWerknemer addWerknemer = new AddWerknemer();
            if (addWerknemer.ShowDialog()== DialogResult.OK)
            {
                werknemersList.Add(addWerknemer.newWerknemer);
                listBox1.DataSource = null;
                listBox1.DataSource = werknemersList;
            }
        }
    }
}
