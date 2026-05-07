using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abbufe
{
    public partial class Form1 : Form
    {
        string azonosito;
        void tablakitoltes()
        {
            dgadatok.Rows.Clear();
            string kereses = "";
            if (txkereses.TextLength > 0)
            {
                kereses = " where vevo like '"+txkereses.Text+"%' ";
            }
            string lekerdezes = "select *, menny * brutto as fizetendo from forgalom "+kereses+" ";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while(ab.Dr.Read())
            {
                DateTime datumka = Convert.ToDateTime(ab.Dr["datum"]);
                dgadatok.Rows.Add(ab.Dr["sorszam"], ab.Dr["vevo"], datumka.ToString("yyyy-MM-dd"), ab.Dr["termek"], ab.Dr["menny"], ab.Dr["brutto"], ab.Dr["fizetendo"]);
            }
        }

        void torles()
        {
            txsorszam.Clear();
            txvevo.Clear();
            dtdatum.Value = DateTime.Now;
            txtermek.Clear();
            txmenny.Clear();
            txbrutto.Clear();
        }

        void fizetendoSzamolas()
        {
            int fizetendo = 0;
            if (txmenny.TextLength > 0 && txbrutto.TextLength > 0)
            {
                fizetendo = Convert.ToInt32(txmenny.Text) * Convert.ToInt32(txbrutto.Text);
            }
            lbosszeg.Text = fizetendo.ToString() + " Ft";
        }

        public Form1()
        {
            InitializeComponent();
            tablakitoltes();
            plujadat.Visible = false;
            dgadatok.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txkereses_TextChanged(object sender, EventArgs e)
        {
            tablakitoltes();
        }

        private void txmenny_TextChanged(object sender, EventArgs e)
        {
            int szam = 0;
            if (txmenny.TextLength > 0)
            {
                try
                {
                    szam = Convert.ToInt32(txmenny.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    txmenny.Clear();
                    txmenny.Focus();
                }
            }
            fizetendoSzamolas();
        }

        private void txbrutto_TextChanged(object sender, EventArgs e)
        {
            int szam = 0;
            if (txbrutto.TextLength > 0)
            {
                try
                {
                    szam = Convert.ToInt32(txbrutto.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbrutto.Clear();
                    txbrutto.Focus();
                }
            }
            fizetendoSzamolas();
        }

        private void txsorszam_TextChanged(object sender, EventArgs e)
        {
            int szam = 0;
            if (txsorszam.TextLength > 0)
            {
                try
                {
                    szam = Convert.ToInt32(txsorszam.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!", "hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txsorszam.Clear();
                    txsorszam.Focus();
                }
            }
        }

        private void btmentes_Click(object sender, EventArgs e)
        {

            if (txsorszam.TextLength < 1)
            {
                MessageBox.Show("Kötelező megadni a sorszámot!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txsorszam.Focus();
            }
            else if(txvevo.TextLength < 1)
            {
                MessageBox.Show("Kötelező megadni a vevő nevét!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txvevo.Focus();
            }
            else if(txtermek.TextLength < 1)
            {
                MessageBox.Show("Kötelező megadni a termék nevét!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txvevo.Focus();
            }
            else if(txmenny.TextLength < 1)
            {
                MessageBox.Show("Kötelező megadni a mennyiséget!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txmenny.Focus();
            }
            else if(txbrutto.TextLength < 1)
            {
                MessageBox.Show("Kötelező megadni a brutto árat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbrutto.Focus();
            }
            else
            {
                if (rbuj.Checked)
                {
                    string lekerdezes = "select count(sorszam) as db from forgalom where sorszam = '" + txsorszam.Text + "'";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                    int sorokszama = Convert.ToInt32(ab.Dr["db"]);
                    ab.lezaras();
                    if (sorokszama == 1)
                    {
                        MessageBox.Show("Ilyen sorszámú tétel már létezik!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txsorszam.Clear();
                        txsorszam.Focus();
                    }
                    else
                    {
                        lekerdezes = "insert into forgalom (sorszam, vevo, datum, termek, menny, brutto) values ('" + txsorszam.Text + "','" + txvevo.Text + "','" + dtdatum.Text + "','" + txtermek.Text + "','" + txmenny.Text + "','" + txbrutto.Text + "')";
                        ab = new Adatbazis(lekerdezes);
                        ab.Dr.Read();
                        ab.lezaras();
                    }
                }
                else
                {
                    string lekerdezes = "update forgalom set vevo='"+txvevo.Text+"', datum='"+dtdatum.Text+"', termek='"+txtermek.Text+"', menny='"+txmenny.Text+"', brutto='"+txbrutto.Text+"' where sorszam = '"+azonosito+"'";
                    Adatbazis ab = new Adatbazis(lekerdezes);
                    ab.Dr.Read();
                }
                tablakitoltes();
                torles();
            }
        }

        private void btelvet_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan elveti?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz == DialogResult.Yes)
            {
                torles();
            }
        }

        private void rbmodosit_CheckedChanged(object sender, EventArgs e)
        {
            dgadatok.Enabled = true;
            plujadat.Visible = false;
        }

        private void rbuj_CheckedChanged(object sender, EventArgs e)
        {
            torles();
            dgadatok.Enabled = false;
            plujadat.Visible = true;
            txsorszam.Enabled = true;
        }

        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plujadat.Visible = true;
            DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            azonosito = sor.Cells["sorszam"].Value.ToString();
            txsorszam.Text = azonosito;
            txsorszam.Enabled = false;
            txvevo.Text = sor.Cells["vevo"].Value.ToString();
            dtdatum.Text = sor.Cells["datum"].Value.ToString();
            txtermek.Text = sor.Cells["termek"].Value.ToString();
            txmenny.Text = sor.Cells["menny"].Value.ToString();
            txbrutto.Text = sor.Cells["brutto"].Value.ToString();
        }
    }
}
