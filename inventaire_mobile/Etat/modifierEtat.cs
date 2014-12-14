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
    public partial class modifierEtat : Form
    {
        etat_traitement trait = new etat_traitement();
        private static String etatAreparer;
        
        public modifierEtat()
        {
            InitializeComponent();
            trait.charger_etat_combobox(cb_etat);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            trait.modifier_etat(tb_desigetat.Text.ToString(), etatAreparer);
            //cb_etat.Refresh();
            this.Close();
        }

        private void cb_etat_SelectedIndexChanged(object sender, EventArgs e)
        {

            //cb_etat.SelectedValue.ToString();
            //remplirTextBox(cb_etat.SelectedValue.ToString());
            tb_desigetat.Text = cb_etat.Text;
            etatAreparer = cb_etat.Text;

        }
        
        private void remplirTextBox(string valeur)
        {
            tb_desigetat.Text  = valeur;
        }
    }
}