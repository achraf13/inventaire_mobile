using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using inventaire_mobile.Localisation.Site;

namespace inventaire_mobile
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Inventaire.Inventaire inv = new Inventaire.Inventaire();
            inv.ShowDialog();
        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Etat.Etat etat = new Etat.Etat();
            etat.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Localisation.Site.site site = new Localisation.Site.site();
            site.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}