using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class frmConversion : Form
    {
        public frmConversion()
        {
            InitializeComponent();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtValeur.Text) < 0 || int.Parse(txtValeur.Text) > 255)
            {
                MessageBox.Show("La valeur doit être comprise entre 0 et 255.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValeur.Focus();
                return;
            }

            txtDecimal.Text = txtValeur.Text;
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            int Valeur = int.Parse(txtValeur.Text), Nombre = 0;
            string Resultat = "";

            if (Valeur < 0 || Valeur > 255)
            {
                MessageBox.Show("La valeur doit être comprise entre 0 et 255.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValeur.Focus();
                return;
            }

            for(int i = 0; i < 8; i++)
            {
                Nombre = Valeur % 2;
                Valeur = Valeur / 2;
                Resultat = Nombre + Resultat;
            }

            Resultat = "b" + Resultat;

            txtBinaire.Text = Resultat;

        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            int Valeur = int.Parse(txtValeur.Text), Nombre = 0;
            string Resultat = "";

            if (Valeur < 0 || Valeur > 255)
            {
                MessageBox.Show("La valeur doit être comprise entre 0 et 255.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValeur.Focus();
                return;
            }

            for (int i = 0; i < 2; i++)
            {
                Nombre = Valeur % 16;

                if(Nombre == 10)
                {
                    Valeur = Valeur / 16;
                    Resultat = "A" + Resultat;
                }
                else if (Nombre == 11)
                {
                    Valeur = Valeur / 16;
                    Resultat = "B" + Resultat;
                }
                else if (Nombre == 12)
                {
                    Valeur = Valeur / 16;
                    Resultat = "C" + Resultat;
                }
                else if (Nombre == 13)
                {
                    Valeur = Valeur / 16;
                    Resultat = "D" + Resultat;
                }
                else if (Nombre == 14)
                {
                    Valeur = Valeur / 16;
                    Resultat = "E" + Resultat;
                }
                else if (Nombre == 15)
                {
                    Valeur = Valeur / 16;
                    Resultat = "F" + Resultat;
                }
                else
                {
                    Valeur = Valeur / 16;
                    Resultat = Nombre + Resultat;
                }
            }

            Resultat = "0x" + Resultat;

            txtHexa.Text = Resultat;
        }
    }
}
