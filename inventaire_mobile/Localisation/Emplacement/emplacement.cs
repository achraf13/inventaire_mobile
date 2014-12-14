using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using inventaire_mobile.Localisation.Site;

namespace inventaire_mobile.Localisation.Emplacement
{
    public partial class emplacement : Form
    {
        public string codeSite;
        public emplacement(string codeSite)
        {
            this.codeSite = codeSite;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tb_codEmpla_Click(object sender, EventArgs e)
        {
            emplacement_traitement trait = new emplacement_traitement();
            trait.trait_empla(tb_codeEmpla.Text.ToString(), codeSite);
        }

        private void tb_codeEmpla_TextChanged(object sender, EventArgs e)
        {

        }
        public string getEmplacement()
        {
            return tb_codeEmpla.Text.ToString();
        }
    }
}