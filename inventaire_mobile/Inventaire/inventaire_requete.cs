using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventaire_mobile.Inventaire
{
    class inventaire_requete
    {
        public DataSet select_inventaire()
        {
            try
            {
                string requete = "SELECT * FROM Inventaire ";
                //cbE.DisplayMember = "id_etat"; 
                //cbE.ValueMember = "desig_etat";

                DataSet ds = Requete.ExecuteSelect(requete);
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}
