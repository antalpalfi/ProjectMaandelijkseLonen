using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMaandelijkseLonen
{
    public partial class AddWerknemer : Form
    {
        public Werknemers newWerknemer = new Werknemers();
        public AddWerknemer()
        {
            InitializeComponent();
        }

        private void AddWerknemer_Load(object sender, EventArgs e)
        {
            cmbFunkcie.Items.Add( Werknemers.Funkcie.Standaardwerker);
            cmbFunkcie.Items.Add(Werknemers.Funkcie.Programmeur);
            cmbFunkcie.Items.Add(Werknemers.Funkcie.Support);
            cmbFunkcie.Items.Add(Werknemers.Funkcie.ITsupport);
            cmbFunkcie.Items.Add(Werknemers.Funkcie.Customersupport);
            //cmbContract.Items.Add(Werknemers.ConractType.Voltijds);
            //cmbContract.Items.Add(Werknemers.ConractType.Deeltijds);



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (cmbFunkcie.SelectedItem)
            {
                case Werknemers.Funkcie.Standaardwerker:
                    if (rdbMan.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;

                    }
                    else if (rdbMan.Checked && rdbDeeltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    else if (rdbVrouw.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    }
                    else
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    newWerknemer.Naam = txtNaam.Text;
                    newWerknemer.RijkRegNum = txtrijkreg.Text;
                    newWerknemer.GeboortDatum = dateTimeGebort.Value;
                    newWerknemer.Iban = txtIban.Text;
                    newWerknemer.StartTime = dateTimeStartDatum.Value;
                    newWerknemer.Work = Werknemers.Funkcie.Standaardwerker;
                    newWerknemer.Uuren = (int)numUur.Value;
                    newWerknemer.Startloon = 1900;
                    newWerknemer.BedrijfWagen = false;
                    //newWerknemer.TypeOfContract = (cmbContract.SelectedItem as Werknemers.ConractType;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    DialogResult = DialogResult.OK;
                    break;
                case Werknemers.Funkcie.Programmeur:
                    if (rdbMan.Checked && rdbJa.Checked && rdbVoltijds.Checked)
                    {
                        
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.BedrijfWagen = true;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    }
                    else if (rdbMan.Checked && rdbNo.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.BedrijfWagen = false;
                    }
                    else if (rdbVrouw.Checked && rdbJa.Checked)
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.BedrijfWagen = true;
                    }
                    else
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.BedrijfWagen = false;
                    }
                    newWerknemer.Naam = txtNaam.Text;
                    newWerknemer.RijkRegNum = txtrijkreg.Text;
                    newWerknemer.GeboortDatum = dateTimeGebort.Value;
                    newWerknemer.Iban = txtIban.Text;
                    newWerknemer.StartTime = dateTimeStartDatum.Value;
                    newWerknemer.Work = Werknemers.Funkcie.Programmeur;
                    newWerknemer.Uuren = (int)numUur.Value;
                    newWerknemer.Startloon = 2200;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    DialogResult = DialogResult.OK;
                    break;
                case Werknemers.Funkcie.Support:
                    if (rdbMan.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;

                    }
                    else if (rdbMan.Checked && rdbDeeltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    else if (rdbVrouw.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    }
                    else
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    newWerknemer.Naam = txtNaam.Text;
                    newWerknemer.RijkRegNum = txtrijkreg.Text;
                    newWerknemer.GeboortDatum = dateTimeGebort.Value;
                    newWerknemer.Iban = txtIban.Text;
                    newWerknemer.StartTime = dateTimeStartDatum.Value;
                    newWerknemer.Work = Werknemers.Funkcie.Support;
                    newWerknemer.Uuren = (int)numUur.Value;
                    newWerknemer.Startloon = 2050;
                    newWerknemer.BedrijfWagen = false;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    DialogResult = DialogResult.OK;
                    break;
                case Werknemers.Funkcie.ITsupport:
                    if (rdbMan.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                    }
                    else
                    {
                        newWerknemer.Geslagh = "Vrouw";
                    }
                    newWerknemer.Naam = txtNaam.Text;
                    newWerknemer.RijkRegNum = txtrijkreg.Text;
                    newWerknemer.GeboortDatum = dateTimeGebort.Value;
                    newWerknemer.Iban = txtIban.Text;
                    newWerknemer.StartTime = dateTimeStartDatum.Value;
                    newWerknemer.Work = Werknemers.Funkcie.ITsupport;
                    newWerknemer.Uuren = 38;
                    newWerknemer.Startloon = 2050;
                    newWerknemer.BedrijfWagen = false;
                    newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    DialogResult = DialogResult.OK;
                    break;
                case Werknemers.Funkcie.Customersupport:
                    if (rdbMan.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;

                    }
                    else if (rdbMan.Checked && rdbDeeltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    else if (rdbVrouw.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    }
                    else
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    newWerknemer.Naam = txtNaam.Text;
                    newWerknemer.RijkRegNum = txtrijkreg.Text;
                    newWerknemer.GeboortDatum = dateTimeGebort.Value;
                    newWerknemer.Iban = txtIban.Text;
                    newWerknemer.StartTime = dateTimeStartDatum.Value;
                    newWerknemer.Work = Werknemers.Funkcie.Customersupport;
                    newWerknemer.Uuren = (int)numUur.Value;
                    newWerknemer.Startloon = 2050;
                    newWerknemer.BedrijfWagen = false;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    DialogResult = DialogResult.OK;
                    break;
                default:
                    break;
            }
           
        }

        private void cmbFunkcie_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFunkcie.SelectedItem)
            {
                case Werknemers.Funkcie.Programmeur:
                    rdbJa.Enabled = true;
                    rdbNo.Enabled = true;
                    numUur.Value = 0;
                    numUur.Enabled = true;
                    rdbDeeltijds.Enabled = true;
                    rdbVoltijds.Enabled = true;
                    rdbVoltijds.Checked = false;
                    labelStartLoon.Text = "2200$";
                    break;
                case Werknemers.Funkcie.Standaardwerker:
                    labelStartLoon.Text = "1900$";
                    numUur.Value = 0;
                    numUur.Enabled = true;
                    rdbJa.Enabled = false;
                    rdbNo.Enabled = false;
                    rdbNo.Checked = true;
                    rdbDeeltijds.Enabled = true;
                    rdbVoltijds.Enabled = true;
                    rdbVoltijds.Checked = false;
                    break;
                case Werknemers.Funkcie.Support:
                    labelStartLoon.Text = "2050$";
                    numUur.Value = 0;
                    numUur.Enabled = true;
                    rdbJa.Enabled = false;
                    rdbNo.Enabled = false;
                    rdbNo.Checked = true;
                    rdbDeeltijds.Enabled = true;
                    rdbVoltijds.Enabled = true;
                    rdbVoltijds.Checked = false;
                    break;
                case Werknemers.Funkcie.ITsupport:
                    labelStartLoon.Text = "2050$";
                    numUur.Value = 38;
                    numUur.Enabled = false;
                    rdbJa.Enabled = false;
                    rdbNo.Enabled = false;
                    rdbNo.Checked = true;
                    rdbDeeltijds.Enabled = false;
                    rdbVoltijds.Enabled = false;
                    rdbVoltijds.Checked = true;
                    
                    break;
                case Werknemers.Funkcie.Customersupport:
                    labelStartLoon.Text = "2050$";
                    numUur.Value = 0;
                    numUur.Enabled = true;
                    rdbJa.Enabled = false;
                    rdbNo.Enabled = false;
                    rdbNo.Checked = true;
                    rdbDeeltijds.Enabled = true;
                    rdbVoltijds.Enabled = true;
                    rdbVoltijds.Checked = false;
                    break;
                default:
                    break;
            }
        }
    }
}
