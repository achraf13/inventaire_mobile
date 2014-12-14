using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace inventaire_mobile.Localisation.Bien
{
    class bien_requete
    {


        public int ajouterBien(string codeBien,string etatBien)
        {
            try
            {
                string reqBien = "INSERT INTO Bien (idBien,idCategorieBien,idBienSeq, desigBien,dateAquisitionBien ,personne ,prix , photo, ancienCode,idFournisseur,marque,numSerie, fournisseur,etat) VALUES (" + codeBien + ",NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'" + etatBien + "') ";
                int nbreDeLigne = Requete.ExecuteUpdate(reqBien);
                return nbreDeLigne;
            }
            catch (Exception)
            {

                return -1;
            }
           

        }
        //___________________________________________________________


        public DataSet select_etat()
        {
            try
            {
                string requete = "SELECT   idetat, desigEtat  FROM Etat ";
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
        public int ajouterSeTrouveBien(string inventaire,string codeBien,string etat,string codeSite,string codeEmpla)
        {
            try
            {
                string reqBien = "INSERT INTO SeTrouveB (idInventaire,idSite,idEmpla,idBien,idEtat) VALUES ("+inventaire+","+codeBien+","+etat+","+codeSite+","+codeEmpla+") ";
                int nbreDeLigne = Requete.ExecuteUpdate(reqBien);
                return nbreDeLigne;
            }
            catch (Exception)
            {

                return -1;
            }
        
        }
    }
}
