using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventaire_mobile.Etat
{
    public partial class Etat : Form
    {
        public Etat()
        {
            InitializeComponent();
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ajouterEtat obj = new ajouterEtat();
            obj.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            modifierEtat mod = new modifierEtat();
            mod.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            supprimerEtat sup = new supprimerEtat();
            sup.ShowDialog();
        }
    }
}