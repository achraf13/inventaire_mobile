using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace inventaire_mobile.Inventaire
{
    class inventaire_traitement
    {
        inventaire_requete invrequete = new inventaire_requete();


        public struct strucEtat
        {
            string idInventaire;
            string dsgInventaire;

            public strucEtat(string idInventaire, string dsgInventaire)
            {
                this.idInventaire = idInventaire;
                this.dsgInventaire = dsgInventaire;
            }
            public string id_Inventaire
            {
                get { return idInventaire; }
                //set { id_Etat = value; }
            }

            public string dsg_Inventaire
            {
                get { return dsgInventaire; }
                //set { dsgEtat = value; }
            }
        }
        //***************************************************************
        public static string etat;
        public void trait_inventaire(ComboBox cb_chargerInv)
        {
            DataSet ds7 = invrequete.select_inventaire();

            foreach (DataRow row in ds7.Tables[0].Rows)
            {
                strucEtat etatbien = new strucEtat(row[0].ToString(), row[1].ToString());
                cb_chargerInv.Items.Add(etatbien);
            }
            try
            {
                cb_chargerInv.Text = ds7.Tables[0].Rows[0][1].ToString();
                // cbEtat.SelectedText = ds7.Tables[0].Rows[0][1].ToString(); 
                //  cbEtat.SelectedValue = ds7.Tables[0].Rows[0][1].ToString();
                //cbEtat.DisplayMember = ds7.Tables[0].Rows[0][1].ToString();

                etat = ds7.Tables[0].Rows[0][0].ToString();

            }
            catch (Exception)
            {

            }

        }
        public void verifierInventaire()
        {
            
        }
    }
}
