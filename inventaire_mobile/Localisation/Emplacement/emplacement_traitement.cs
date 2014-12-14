using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace inventaire_mobile.Localisation.Emplacement
{
    class emplacement_traitement : Site.site_traitement 
    {
        
        public void trait_empla(string codeEmpla,string codeSite)
        {
            emplacement_requete req2 = new emplacement_requete();
            DataSet ds2 = req2.select_emplacement(codeEmpla);

            if (ds2.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Emplacement inconnu");
            }
            else
            {
                 Bien.bien bien = new Bien.bien(codeSite,codeEmpla);

                bien.Show();
            }

        }
    }
}
