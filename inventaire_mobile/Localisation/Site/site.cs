using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventaire_mobile.Localisation.Site
{
    public partial class site : Form
    {
        public site()
        {
            InitializeComponent();
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            site_traitement obj=new site_traitement();
            obj.trait_site(tb_codeSite.Text.ToString());
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void tb_codeSite_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}