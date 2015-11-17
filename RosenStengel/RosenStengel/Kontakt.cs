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

        private void cbNeu_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbNeu.Checked == true && cbBearbeiten.Checked == true) || (cbNeu.Checked == true && cbLoeschen.Checked == true) )
            {
                MessageBox.Show("Sie können nur einen Aktion auswählen","Information");
            }
                if (cbNeu.Checked == true)
            {
                tbAdresse.Text = " ";
                tbEmail.Text = " ";
                tbName.Text = " ";
                tbTelefon.Text = " ";
                tbVorname.Text = " ";
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if ((cbLoeschen.Checked == true && cbBearbeiten.Checked == true) || (cbBearbeiten.Checked == true && cbLoeschen.Checked == true) || (cbNeu.Checked == true && cbBearbeiten.Checked == true))
            {
                MessageBox.Show("Sie können nur einen Aktion auswählen", "Information");   
            }
            if (cbNeu.Checked == true)
            {
                MessageBox.Show("Der Satz wurde angelegt!");
            }
            else if (cbBearbeiten.Checked == true)
            {
                MessageBox.Show("Der Satz wurde bearbeitet!");
            }
            else if (cbLoeschen.Checked == true)
            {
                MessageBox.Show("Der Satz wurde gelöscht");
            }
        }

        private void cbBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbNeu.Checked == true && cbBearbeiten.Checked == true) || (cbBearbeiten.Checked == true && cbLoeschen.Checked == true))
            {
                MessageBox.Show("Sie können nur einen Aktion auswählen", "Information");
            }
        }

        private void cbLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbLoeschen.Checked == true && cbBearbeiten.Checked == true) || (cbBearbeiten.Checked == true && cbLoeschen.Checked == true))
            {
                MessageBox.Show("Sie können nur einen Aktion auswählen", "Information");
            }
        }
    }
}
