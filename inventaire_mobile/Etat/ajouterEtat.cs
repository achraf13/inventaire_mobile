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
    public partial class ajouterEtat : Form
    {
        etat_traitement trait = new etat_traitement();

        public ajouterEtat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            trait.trait_etat_ajouter(tb_ajouterEtat.Text.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}