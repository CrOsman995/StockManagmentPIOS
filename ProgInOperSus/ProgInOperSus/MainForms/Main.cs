using ProgInOperSus.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgInOperSus.MainForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void skladišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkladisteForm NF = new SkladisteForm();
            NF.MdiParent = this;
            NF.Dock = DockStyle.Fill;
            NF.Show();
           
        }

        private void primkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimkaForm NF = new PrimkaForm();
            NF.MdiParent = this;
          //  NF.Dock = DockStyle.Fill;
            NF.Show();
        }

        private void otpremnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtpremnicaForm NF = new OtpremnicaForm();
            NF.MdiParent = this;
            NF.Dock = DockStyle.Fill;
            NF.Show();
        }

        private void poslovniPartneriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoslovniPartnerForm NF = new PoslovniPartnerForm();
            NF.MdiParent = this;
            NF.Dock = DockStyle.Fill;
            NF.Show();
        }

        private void šifrarnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifrarnikForm NF = new SifrarnikForm();
            NF.MdiParent = this;
            NF.Dock = DockStyle.Fill;
            NF.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostavkeSkladistaForm NF = new PostavkeSkladistaForm();
            NF.MdiParent = this;
            NF.Dock = DockStyle.Fill;
            NF.Show();
        }

        private void djelatniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KorisnickiRacunForm NF = new KorisnickiRacunForm();
            NF.MdiParent = this;
            NF.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void promjenakorisničkogRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            LoginForm LF = new LoginForm();
            this.Hide();            
            LF.ShowDialog();
            this.Close();
        }

        private void adreseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adrese NF = new Adrese();
            NF.MdiParent = this;
            NF.Show();
        }
    }
}
