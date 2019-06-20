using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnaPrace_MykytaVorobiov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void odejítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info Info = new info();
            Info.Show();
            this.Hide();
        }

        private void elektrotechnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PřevodJednotekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KancelářskéBalíčkyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MbitsDoMBsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CoToJeDátovyTypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PGM_dtvTp PGM1 = new PGM_dtvTp();
            PGM1.Show();
            this.Hide();
        }

        private void ChybyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PGM_chb PGM2 = new PGM_chb();
            PGM2.Show();
            this.Hide();
        }

        private void ProgramovacíJazykyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PGM_lang PGM3 = new PGM_lang();
            PGM3.Show();
            this.Hide();
        }

        private void KalkulačkyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OhmůvZákonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Calc_ZAE_ohm ohm = new Calc_ZAE_ohm();
            ohm.Show();
        }

        private void PředmětyToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.předmětyToolStripMenuItem.Font = new Font(předmětyToolStripMenuItem.Font.Name, 17);
            this.předmětyToolStripMenuItem.ForeColor = Color.Red;
        }

        private void PředmětyToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.předmětyToolStripMenuItem.Font = new Font(předmětyToolStripMenuItem.Font.Name, 14);
            this.předmětyToolStripMenuItem.ForeColor = Color.Black;
        }

        private void KalkulačkyToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.kalkulačkyToolStripMenuItem.Font = new Font(kalkulačkyToolStripMenuItem.Font.Name, 17);
            this.kalkulačkyToolStripMenuItem.ForeColor = Color.Red;
        }

        private void KalkulačkyToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.kalkulačkyToolStripMenuItem.Font = new Font(kalkulačkyToolStripMenuItem.Font.Name, 14);
            this.kalkulačkyToolStripMenuItem.ForeColor = Color.Black;
        }

        private void PřevodJednotekToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.převodJednotekToolStripMenuItem.Font = new Font(převodJednotekToolStripMenuItem.Font.Name, 17);
            this.převodJednotekToolStripMenuItem.ForeColor = Color.Red;
        }

        private void PřevodJednotekToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.převodJednotekToolStripMenuItem.Font = new Font(převodJednotekToolStripMenuItem.Font.Name, 14);
            this.převodJednotekToolStripMenuItem.ForeColor = Color.Black;
        }

        private void PřestávkaToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.přestávkaToolStripMenuItem.Font = new Font(přestávkaToolStripMenuItem.Font.Name, 17);
            this.přestávkaToolStripMenuItem.ForeColor = Color.Red;
        }

        private void PřestávkaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.přestávkaToolStripMenuItem.Font = new Font(přestávkaToolStripMenuItem.Font.Name, 14);
            this.přestávkaToolStripMenuItem.ForeColor = Color.Black;
        }

        private void OdejítToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            this.odejítToolStripMenuItem.Font = new Font(odejítToolStripMenuItem.Font.Name, 17);
            this.odejítToolStripMenuItem.ForeColor = Color.Red;
        }

        private void OdejítToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            this.odejítToolStripMenuItem.Font = new Font(odejítToolStripMenuItem.Font.Name, 16);
            this.odejítToolStripMenuItem.ForeColor = Color.Black;
        }

        private void InfoToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            this.infoToolStripMenuItem1.Font = new Font(infoToolStripMenuItem1.Font.Name, 17);
            this.infoToolStripMenuItem1.ForeColor = Color.Red;
        }

        private void InfoToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            this.infoToolStripMenuItem1.Font = new Font(infoToolStripMenuItem1.Font.Name, 14);
            this.infoToolStripMenuItem1.ForeColor = Color.Black;
        }
    }
}
