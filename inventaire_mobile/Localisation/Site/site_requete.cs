using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace inventaire_mobile.Localisation.Site
{
    class site_requete
    {
        public DataSet select_site(string codeSite)
        {
            try
            {
                DataSet dssite = null;
                string req_site = "SELECT * FROM  site WHERE (idSite='" + codeSite + "')";
                dssite = Requete.ExecuteSelect(req_site);
                return dssite;
            }
            catch
            {
                MessageBox.Show("erreur");
                return null;
            }
        }
    }
}
