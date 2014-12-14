using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace inventaire_mobile.Localisation.Site
{
    class site_traitement
    {
        public string codeSite;

        public void trait_site(string codeSite)
        {
            site_requete req2 = new site_requete();
            DataSet ds2 = req2.select_site(codeSite);

            if (ds2.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("site inconnu");
            }
            else
            {
                //MessageBox.Show("site trouvé");
                new Emplacement.emplacement(codeSite).Show();
                
                this.codeSite = codeSite;
            }

        }
        public string getCodeSite()
        {
            return codeSite;
        }
        

       
    }
}
