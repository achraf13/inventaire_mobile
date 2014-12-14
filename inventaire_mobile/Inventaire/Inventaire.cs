using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventaire_mobile.Inventaire
{
    public partial class Inventaire : Form
    {
        inventaire_traitement invtrait = new inventaire_traitement();
        public static string inventaire;
        public Inventaire()
        {
            InitializeComponent();
            invtrait.trait_inventaire(cb_chargerInv);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inventaire = cb_chargerInv.Text.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {

        }

        private void cb_chargerInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventaire = cb_chargerInv.Text.ToString();
        }
        public  string getInventaire()
        {
            return inventaire;
        }
    }
}