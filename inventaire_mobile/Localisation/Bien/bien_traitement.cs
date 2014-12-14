using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace inventaire_mobile.Localisation.Bien
{
    class bien_traitement
    {
        bien_requete scnreq = new bien_requete();

        public void trait_bien(string codeBien,string etatBien)
        {
            bien_requete req = new bien_requete();
            int nbre = req.ajouterBien(codeBien,etatBien);

            if (nbre == 0)
            {
                MessageBox.Show("Echec durant l'enregistrement dans la base de donnee");
            }
            else
            {
                MessageBox.Show("bien inseré avec succée");
                bien bien =new bien(null,null);
                bien.ShowDialog();
            }

        }

        public struct strucEtat
        {
            string id_Etat;
            string dsgEtat;

            public strucEtat(string id_Etat, string dsgEtat)
            {
                this.id_Etat = id_Etat;
                this.dsgEtat = dsgEtat;
            }
            public string idetat
            {
                get { return id_Etat; }
                //set { id_Etat = value; }
            }

            public string dsgetat
            {
                get { return dsgEtat; }
                //set { dsgEtat = value; }
            }
        }
        //******************************* Methode pour remplir le combobox ********************************
        public static string etat;
        public void trait_etat(ComboBox cbEtat)
        {
            DataSet ds7 = scnreq.select_etat();

            foreach (DataRow row in ds7.Tables[0].Rows)
            {
                strucEtat etatbien = new strucEtat(row[0].ToString(), row[1].ToString());
                cbEtat.Items.Add(etatbien);
            }
            try
            {
                cbEtat.Text = ds7.Tables[0].Rows[0][1].ToString();
                // cbEtat.SelectedText = ds7.Tables[0].Rows[0][1].ToString(); 
                //  cbEtat.SelectedValue = ds7.Tables[0].Rows[0][1].ToString();
                //cbEtat.DisplayMember = ds7.Tables[0].Rows[0][1].ToString();

                etat = ds7.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception)
            {

            }

        }

        // *************methode pour enregistrer daans la table SeTrouveBien ******************
        public void remplirSeTrouveBien(string inventaire,string codeBien,string etat,string codeSite,string codeEmpla)
        {
            bien_requete req = new bien_requete();
            req.ajouterSeTrouveBien(inventaire, codeBien,etat,codeSite,codeEmpla);
        }

    }
}
