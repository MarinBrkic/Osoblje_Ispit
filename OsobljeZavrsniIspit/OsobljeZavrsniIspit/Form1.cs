using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsobljeZavrsniIspit
{
    public partial class Form1 : Form
    {
        List<Osoba> osobaList = new List<Osoba>();
        string aktivnost;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIme.Text == "" ||
                    txtPrezime.Text == "" ||
                    cmbZanimanje.Text == "")
                {
                    MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                                        "Pogrešan unos", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    txtIme.Clear();
                    txtPrezime.Clear();
                    txtIme.Focus();
                }
                else
                {
                    Osoba osoba = new Osoba(txtIme.Text,
                        txtPrezime.Text,
                        cmbZanimanje.Text,
                        cmbFilter.Text, aktivnost);
                    osobaList.Add(osoba);
                    txtIme.Clear();
                    txtPrezime.Clear();
                    txtIme.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                    "Pogrešan unos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtIme.Clear();
                txtPrezime.Clear();
            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            foreach (Osoba v in osobaList)
            {
                textBoxPodatci.AppendText(v.ToString());
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //textBoxPodatci.Text = string.Empty;

            foreach (Osoba v in osobaList)
            {
                if (v.Filter == "Samo Učenici")
                {
                    if (v.Zanimanje == "Učenik")
                    {
                        textBoxPodatci.Text = v.ToString();
                    }
                }
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach (Osoba v in osobaList)
            {
                if (v.Zanimanje == "Učenik")
                {
                    v.Aktivnost = "Uči";
                }
                else if (v.Zanimanje == "Učitelj")
                {
                    v.Aktivnost = "Predaje";
                }
                else
                {
                    v.Aktivnost = "Održava";
                }
            }
        }
    }
}
