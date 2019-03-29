using ProgInOperSus.MainForms.KorisnickiRacun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgInOperSus.MainForm
{
    public partial class KorisnickiRacunForm : Form
    {
        public KorisnickiRacunForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DodajRacun NF = new DodajRacun();
            NF.Show();

        }

        private void btnIzbrisiRacun_Click(object sender, EventArgs e)
        {
            //TODO izbrisi racun iz baze

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
