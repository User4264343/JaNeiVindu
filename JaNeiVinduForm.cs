using System;
using System.Windows.Forms;

namespace JaNeiVindu
{
    public partial class JaNeiForm : Form
    {
        public bool ja;
        public JaNeiForm(string tekst)
        {
            InitializeComponent();
            labelTekst.Text = tekst;
        }

        private void ButtonJa_Click(object sender, EventArgs e)
        {
            ja = true;
            this.Close();
        }

        private void ButtonNei_Click(object sender, EventArgs e)
        {
            ja = false;
            this.Close();
        }
    }
}