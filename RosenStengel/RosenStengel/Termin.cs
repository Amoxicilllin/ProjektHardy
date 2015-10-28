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
    public partial class Termin : Form
    {
        public Termin()
        {
            InitializeComponent();
        }

        private void Termin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Haupt HFrm = new Haupt();
            HFrm.Show();
        }
    }
}
