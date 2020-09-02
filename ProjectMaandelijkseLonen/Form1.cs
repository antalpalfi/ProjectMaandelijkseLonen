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
        Werknemers getWerk = new Werknemers();
        private void Form1_Load(object sender, EventArgs e)
        {
            Werknemers antal = new Werknemers("Antal Palfi","Man", new DateTime(2018,06,13), "Be 1235 1532 1654", new DateTime(1990,06,16), "164598-184-16-06-1990",startloon:1900,work: Werknemers.Funkcie.Baliemedewerker,uuren: 38, conractType: Werknemers.ConractType.Voltijds);
            werknemersList.Add(antal);
            listBox1.DataSource = null;
            listBox1.DataSource = werknemersList;
            //label1.Text = getWerk.WerknemInfo();
            //getWerk.NettoLoon(); 
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (listBox1.SelectedItem as Werknemers).WerknemInfo();
        }
    }
}
