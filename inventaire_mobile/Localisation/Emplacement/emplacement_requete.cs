using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace inventaire_mobile.Localisation.Emplacement
{
    class emplacement_requete
    {
        public DataSet select_emplacement(string codeEmpla)
        {
            try
            {
                DataSet dssite = null;
                string req_site = "SELECT  idEmpla FROM  emplacement WHERE (idEmplaComplet='" +codeEmpla+"')";
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
