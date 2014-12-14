using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventaire_mobile.Etat
{
    class etat_requete
    {

        public int ajouterEtat(string desigEtat)
        {
            try
            {
                string reqBien = "INSERT INTO Etat (idetat,desigEtat) VALUES(,'" + desigEtat + "')";
                int nbreDeLigne = Requete.ExecuteUpdate(reqBien);
                return nbreDeLigne;
            }
            catch (Exception)
            {

                return -1;
            }


        }

        //*******************************************************

        public DataSet select_etat()
        {
            try
            {
                string requete = "Select * FROM Etat  ";
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

        public int modifier_etat(string etatActuel,string etatAreparer)
        {
            try
            {
                string requete = "UPDATE Etat SET desigEtat ='" + etatActuel + "' where desigEtat='" + etatAreparer + "'";
                int nbre = Requete.ExecuteUpdate(requete);
                return nbre;
            }
            catch
            {
                return -1 ;
            }
        }
    }
}
