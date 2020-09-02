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
    public partial class AddWerknemer : Form
    {
        public Werknemers newWerknemer = new Werknemers();
        public AddWerknemer()
        {
            InitializeComponent();
        }

        private void AddWerknemer_Load(object sender, EventArgs e)
        {
            cmbFunkcie.Items.Add("Standaardwerker");
            cmbFunkcie.Items.Add("Programmeur");
            cmbFunkcie.Items.Add("Support");
            cmbFunkcie.Items.Add("ITsupport");
            cmbFunkcie.Items.Add("Customersupport");
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (cmbFunkcie.SelectedItem)
            {
                case "Standaardwerker":
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
                    newWerknemer.Work = Werknemers.Funkcie.Standaardwerker;
                    newWerknemer.Uuren = (int)numUur.Value;
                    newWerknemer.Startloon = 1900;
                    newWerknemer.BedrijfWagen = false;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    DialogResult = DialogResult.OK;
                    break;
                default:
                    break;
            }
            //newWerknemer.Naam = txtNaam.Text;
            //newWerknemer.RijkRegNum = txtrijkreg.Text;
            //newWerknemer.GeboortDatum = dateTimeGebort.Value;
            //newWerknemer.Geslagh = 
        }

        private void cmbFunkcie_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFunkcie.SelectedItem)
            {
                case "Programmeur":
                    rdbJa.Enabled = true;
                    rdbNo.Enabled = true;
                    numUur.Value = 0;
                    numUur.Enabled = true;
                    labelStartLoon.Text = "2200$";
                    break;
                case "Standaardwerker":
                    labelStartLoon.Text = "1900$";
                    numUur.Value = 0;
                    numUur.Enabled = true;
                    rdbJa.Enabled = false;
                    rdbNo.Enabled = false;
                    break;
                case "Support":
                    labelStartLoon.Text = "2050$";
                    numUur.Value = 0;
                    numUur.Enabled = true;
                    rdbJa.Enabled = false;
                    rdbNo.Enabled = false;
                    break;
                case "ITsupport":
                    labelStartLoon.Text = "2050$";
                    numUur.Value = 38;
                    numUur.Enabled = false;
                    rdbJa.Enabled = false;
                    rdbNo.Enabled = false;
                    break;
                case "Customersupport":
                    labelStartLoon.Text = "2050$";
                    numUur.Value = 0;
                    numUur.Enabled = true;
                    rdbJa.Enabled = false;
                    rdbNo.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
