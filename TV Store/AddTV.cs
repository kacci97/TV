using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TV_Store
{
    public partial class AddTV : Form
    {
        public TV TV { get; set; }
        public AddTV()
        {
            InitializeComponent();
        }

        private void AddTV_Load(object sender, EventArgs e)
        {

        }

        private void tbProizvoditel_Validating(object sender, CancelEventArgs e)
        {
            if (tbProizvoditel.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbProizvoditel, "Името на произведителот е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbProizvoditel, null);
                e.Cancel = false;

            }
        }

        private void nudResolucija_Validating(object sender, CancelEventArgs e)
        {
            if (nudResolucija.Value <= 50)
            {
                errorProvider1.SetError(nudResolucija, "Ресолуцијата мора да биде поголема од 50");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudResolucija, null);
                e.Cancel = false;

            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TV = new TV(tbProizvoditel.Text.Trim(),(int)nudResolucija.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
