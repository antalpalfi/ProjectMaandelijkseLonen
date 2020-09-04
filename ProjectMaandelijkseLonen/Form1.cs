using System;
using System.Collections.Generic;
using System.IO;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Werknemers antal = new Werknemers("Antal Palfi", "Man", new DateTime(2018, 06, 13), "Be 1235 1532 1654", new DateTime(1990, 06, 16), "164598-184-16", 1900, work: Werknemers.Funkcie.Standaardwerker, 30, conractType: Werknemers.ConractType.Deeltijds);
            werknemersList.Add(antal);
            Werknemers tomi = new Werknemers("Tomi Palfi", "Man", new DateTime(2018, 06, 13), "Be 1235 1532 1654", new DateTime(1995, 07, 26), "168898-184-26", 2200, work: Werknemers.Funkcie.Programmeur, 38, conractType: Werknemers.ConractType.Voltijds, true);
            werknemersList.Add(tomi);
            Werknemers eszti = new Werknemers("Eszter Boer", "Vrouw", new DateTime(2008, 01, 23), "NL 1235 1532 7854", new DateTime(1978, 04, 11), "168898-184-11", 2050, work: Werknemers.Funkcie.Support, 38, conractType: Werknemers.ConractType.Voltijds);
            werknemersList.Add(eszti);
            Werknemers kriszti = new Werknemers("Krisztina Vigh", "Vrouw", new DateTime(2010, 01, 23), "NL 6535 15892 7854", new DateTime(1985, 04, 18), "174898-184-18", 2050, work: Werknemers.Funkcie.ITsupport, 38, conractType: Werknemers.ConractType.Voltijds);
            werknemersList.Add(kriszti);
            listBox1.DataSource = null;
            listBox1.DataSource = werknemersList;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.DataSource != null)
            {
                label1.Text = (listBox1.SelectedItem as Werknemers).WerknemInfo();
            }
            else
            {
                label1.Text = "Time To Play\n" +
                    "Have a Nice weekend";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox1.Focus();
            listBox1.SelectedIndex = 0;
            werknemersList.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedIndex);
            listBox1.DataSource = null;
            listBox1.DataSource = werknemersList;
            listBox1.Focus();
            if (werknemersList.Count == 0)
            {
                MessageBox.Show("We don't have any workers", "AAaaaaaaa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRemove.Enabled = false;
                btnLoonBrief.Enabled = false;
                btnRecap.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddWerknemer addWerknemer = new AddWerknemer();
            if (addWerknemer.ShowDialog() == DialogResult.OK)
            {
                werknemersList.Add(addWerknemer.newWerknemer);
                listBox1.DataSource = null;
                listBox1.DataSource = werknemersList;
            }
            if (werknemersList.Count == 0)
            {
                btnRemove.Enabled = false;
                btnLoonBrief.Enabled = false;
                btnRecap.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
                btnLoonBrief.Enabled = true;
                btnRecap.Enabled = true;
            }
        }

        private void lbLoonbrief_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Werknemers werknemers = (listBox1.SelectedItem as Werknemers);
                using (StreamWriter writer = new StreamWriter(werknemers.Naam))
                {
                    writer.WriteLine($"Loonbrief {werknemers.Naam} {werknemers.RijkRegNum} {DateTime.Now.ToString("MMMM-yyyy").ToUpper()}");
                    writer.WriteLine(new string('-', 50));
                    writer.WriteLine($"Naam\t\t\t\t\t\t: {werknemers.Naam}");
                    writer.WriteLine($"Rijksregisternummer\t\t\t: {werknemers.RijkRegNum}");
                    writer.WriteLine($"Geslacht\t\t\t\t\t: {werknemers.Geslagh}");
                    writer.WriteLine($"Geboortedatum\t\t\t\t: {werknemers.GeboortDatum.ToString("dd-MMMM-yyyy")}");
                    writer.WriteLine($"Datum Indiensttreding\t\t\t: {werknemers.StartTime.ToString("dd-MMMM-yyyy")}");
                    writer.WriteLine($"Funkcie\t\t\t\t\t: {werknemers.Work}");
                    writer.WriteLine($"Aantal Gepresteerde Uren\t\t: {werknemers.Uuren}/38");

                    writer.Write($"Bedrijfwagen\t\t\t\t: ");
                    if ((werknemers as Werknemers).BedrijfWagen == true)
                    {
                        writer.WriteLine("Ja");
                    }
                    else
                    {
                        writer.WriteLine("No");
                    }
                    writer.WriteLine(new string('-', 50));
                    writer.WriteLine($"Startloon\t\t\t\t\t:   $ {(werknemers as Werknemers).StartMoney()}");
                    writer.WriteLine($"Ancienniteit\t\t\t\t: + $ {Math.Round((werknemers as Werknemers).GeneretAncientSocial() - (werknemers as Werknemers).StartMoney(), 2)}");
                    writer.WriteLine($"\t\t\t\t\t\t    $ {(werknemers as Werknemers).GeneretAncientSocial()}");
                    writer.WriteLine($"Social Zekerheid\t\t\t\t: - $ 200");
                    writer.WriteLine($"\t\t\t\t\t\t    $ {(werknemers as Werknemers).SocialZekeheid()}");
                    writer.Write($"Bedrijfsvoorheffing\t\t\t: - $ ");
                    if ((werknemers as Werknemers).BedrijfWagen == true)
                    {
                        writer.WriteLine($"{Math.Round((werknemers as Werknemers).SocialZekeheid() * 0.1730),2}");
                    }
                    else
                    {
                        writer.WriteLine($"{Math.Round((werknemers as Werknemers).SocialZekeheid() * 0.1368),2}");
                    }
                    if (werknemers.Work.ToString() == "Support")
                    {
                        writer.WriteLine($"\t\t\t\t\t\t    $ {(werknemers as Werknemers).NettoLoon() - 50}");
                        writer.WriteLine($"Thuis werk extra\t\t\t\t: + $ 50");
                        writer.WriteLine($"\t\t\t\t\t\t    $ {(werknemers as Werknemers).NettoLoon()}");
                        writer.WriteLine($"Nettoloon\t\t\t\t\t:   $ {(werknemers as Werknemers).NettoLoon()}");

                    }
                    else if (werknemers.Work.ToString() == "Customersupport")
                    {
                        writer.WriteLine($"\t\t\t\t\t\t    $ {(werknemers as Werknemers).NettoLoon() - 19.50}");
                        writer.WriteLine($"Opleiding\t\t\t\t\t: + $ 19.50");
                        writer.WriteLine($"\t\t\t\t\t\t    $ {(werknemers as Werknemers).NettoLoon()}");
                        writer.WriteLine($"Nettoloon\t\t\t\t\t:    $ {(werknemers as Werknemers).NettoLoon()}");
                    }
                    else
                    {
                        writer.WriteLine($"\t\t\t\t\t\t    $ {(werknemers as Werknemers).NettoLoon()}");
                        writer.WriteLine($"Nettoloon\t\t\t\t\t:   $ {(werknemers as Werknemers).NettoLoon()}");
                    }
                    writer.WriteLine(new string('-', 50));

                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double sumNett = 0;
            foreach (Werknemers item in werknemersList)
            {
                sumNett += item.Netto;
            }
            MessageBox.Show($"Deze maand wij heben total netto ${sumNett} betaald");
        }
    }
}
