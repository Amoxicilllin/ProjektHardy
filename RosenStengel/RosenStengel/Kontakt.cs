using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosenStengel
{
    public partial class Kontakt : Form
    {
        public Kontakt()
        {
            InitializeComponent();
        }

        private void Kontakt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.frmHaupt == null)
            {
                Haupt frmHaupt = new Haupt();
                Program.frmHaupt = frmHaupt;
                frmHaupt.Show();
            }
            else
            {
                Program.frmHaupt.Show();
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if ((cbBearbeiten.Checked == true && cbloeschen.Checked == true) || (cbNeu.Checked == true && cbBearbeiten.Checked == true) || (cbNeu.Checked == true && cbloeschen.Checked == true))
            {
                MessageBox.Show("Du kannst nicht mehrere Sachen auswählen", "Fehler");
            }
            else
            {
                if (cbNeu.Checked == true)
                {
                    MessageBox.Show("Neuer Satz wurde angelegt", "Info");
                }
                else if (cbBearbeiten.Checked == true)
                {
                    MessageBox.Show("Der Satz wurde bearbeitet","Info");
                }
                else if (cbloeschen.Checked == true)
                {
                    MessageBox.Show("Der Satz wurde gelöscht!","Info");
                }
            }
        }
    }
}
