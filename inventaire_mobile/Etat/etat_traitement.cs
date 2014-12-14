using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace inventaire_mobile.Etat
{
    class etat_traitement
    {
        
        public void trait_etat_ajouter(string desigEtat)
        {
            etat_requete req = new etat_requete();
            int nbre = req.ajouterEtat(desigEtat);

            if (nbre == 0)
            {
                MessageBox.Show("Echec durant l'enregistrement dans la base de donnee");
            }
            else
            {
                MessageBox.Show("Enregistrement avec succés");
            }

        }

        //***************************************************************

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
        //***************************************************************
        public static string etat;
        public void charger_etat_combobox(ComboBox cbEtat)
        {
            etat_requete req = new etat_requete();
            DataSet ds7 = req.select_etat();

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
         //************************************************* 
        etat_requete req2 = new etat_requete();
        public void modifier_etat(string desigEtat, string etatAreparer)
        {
            string etatArep = etatAreparer;
            int nombre = req2.modifier_etat(desigEtat, etatArep);

            if (nombre == -1)
            {
                MessageBox.Show("Echec de modification");
            }
            else
            {
                MessageBox.Show("Modification avec succés");
            }

        }
    }
}
