using System;
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
            cmbFunkcie.Items.Add(Werknemers.Funkcie.Standaardwerker);
            cmbFunkcie.Items.Add(Werknemers.Funkcie.Programmeur);
            cmbFunkcie.Items.Add(Werknemers.Funkcie.Support);
            cmbFunkcie.Items.Add(Werknemers.Funkcie.ITsupport);
            cmbFunkcie.Items.Add(Werknemers.Funkcie.Customersupport);
           
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
                    newWerknemer.Uuren = (double)numUur.Value;
                    newWerknemer.Startloon = 1900;
                    newWerknemer.BedrijfWagen = false;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    CheckAlles();
                    break;
                case Werknemers.Funkcie.Programmeur:
                    if (rdbMan.Checked && rdbJa.Checked && rdbVoltijds.Checked)
                    {

                        newWerknemer.Geslagh = "Man";
                        newWerknemer.BedrijfWagen = true;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    }
                    else if (rdbMan.Checked && rdbJa.Checked && rdbDeeltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.BedrijfWagen = true;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    else if (rdbMan.Checked && rdbNo.Checked && rdbDeeltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.BedrijfWagen = false;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    else if (rdbMan.Checked && rdbNo.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Man";
                        newWerknemer.BedrijfWagen = false;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    }

                    else if (rdbVrouw.Checked && rdbJa.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.BedrijfWagen = true;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    }
                    else if (rdbVrouw.Checked && rdbJa.Checked && rdbDeeltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.BedrijfWagen = true;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    else if (rdbVrouw.Checked && rdbNo.Checked && rdbVoltijds.Checked)
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.BedrijfWagen = false;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Voltijds;
                    }
                    else
                    {
                        newWerknemer.Geslagh = "Vrouw";
                        newWerknemer.BedrijfWagen = false;
                        newWerknemer.TypeOfContract = Werknemers.ConractType.Deeltijds;
                    }
                    newWerknemer.Naam = txtNaam.Text;
                    newWerknemer.RijkRegNum = txtrijkreg.Text;
                    newWerknemer.GeboortDatum = dateTimeGebort.Value;
                    newWerknemer.Iban = txtIban.Text;
                    newWerknemer.StartTime = dateTimeStartDatum.Value;
                    newWerknemer.Work = Werknemers.Funkcie.Programmeur;
                    newWerknemer.Uuren = (double)numUur.Value;
                    newWerknemer.Startloon = 2200;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    CheckAlles();
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
                    newWerknemer.Uuren = (double)numUur.Value;
                    newWerknemer.Startloon = 2050;
                    newWerknemer.BedrijfWagen = false;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    CheckAlles();
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
                    CheckAlles();
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
                    newWerknemer.Uuren = (double)numUur.Value;
                    newWerknemer.Startloon = 2050;
                    newWerknemer.BedrijfWagen = false;
                    newWerknemer.Netto = newWerknemer.NettoLoon();
                    CheckAlles();
                    break;
                default:
                    break;
            }
            if (cmbFunkcie.SelectedItem==null)
            {
                Error();
            }
        }
        private  void Error()
        {
            if (txtNaam.Text == "" || txtrijkreg.Text == "" || txtIban.Text == "")
            {
                MessageBox.Show("Uups. Something Missing!! Please fill in all fields", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (DateTime.Now.Year - dateTimeGebort.Value.Year < 18)
            {
                MessageBox.Show("Sorry. Under age of 18 cannot work","Error!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DateTime.Now.Year - dateTimeGebort.Value.Year >= 68)
            {
                MessageBox.Show("Sorry. No place for pension people", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rdbMan.Checked != true && rdbVrouw.Checked != true)
            {
                MessageBox.Show("Geslacht niet correct", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbFunkcie.SelectedItem== null)
            {
                MessageBox.Show("Funkcie nog niet geselecteerd", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (numUur.Value == 0)
            {
                MessageBox.Show("Aantal gepresteerde uren niet duidelijk", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"New employee {(newWerknemer as Werknemers).Naam}");
                DialogResult = DialogResult.OK;
            }
        }
        private void CheckAlles()
        {
            if (txtNaam.Text != "" && txtIban.Text != "" && txtIban.Text != "" && rdbMan.Checked == true && rdbVrouw.Checked == true && numUur.Value != 0 && DateTime.Now.Year - dateTimeGebort.Value.Year >= 18&& cmbFunkcie.SelectedItem != null&& DateTime.Now.Year - dateTimeGebort.Value.Year < 68)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                Error();
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

        private void numUur_ValueChanged(object sender, EventArgs e)
        {
            if (numUur.Value < 38)
            {
                rdbVoltijds.Enabled = false;
                rdbVoltijds.Checked = false;
                rdbDeeltijds.Enabled = true;
                rdbDeeltijds.Checked = true;
            }
            else
            {
                rdbVoltijds.Enabled = true;
                rdbDeeltijds.Checked = false;
                rdbVoltijds.Checked = true;
                //rdbDeeltijds.Enabled = false;
                
            }
        }

        private void rdbVoltijds_CheckedChanged(object sender, EventArgs e)
        {
            numUur.Value = 38;
            numUur.Enabled = false;
            rdbDeeltijds.Enabled = true;
        }

        private void rdbDeeltijds_CheckedChanged(object sender, EventArgs e)
        {
            numUur.Value = 0;
            numUur.Enabled = true;
            rdbVoltijds.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdbVoltijds.Enabled = true;
            rdbDeeltijds.Enabled = true;
            numUur.Value = 1;
        }
    }
}
