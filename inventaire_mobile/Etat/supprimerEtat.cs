using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace inventaire_mobile.Etat
{
    public partial class supprimerEtat : Form
    {
       
        public supprimerEtat()
        {

            /* etat_requete etat =new etat_requete();
             DataSet DS = etat.select_etat();
             DataTable dt = DS.Tables[0];
             DataColumn workCol = dt.Columns.Add("CustID", typeof(string));
            
             for (int i = 0; i < dt.Rows.Count; i++)
                 {
                     DataRow dr = dt.Rows[i];
                     ListViewItem item = new ListViewItem(dr["CustID"].ToString());
                         
                         i++;
                         //listView1.Items.Add(row[i].ToString());
                         item.SubItems.Add(dr["CustID"].ToString());
                         listView1.Items.Add(item);
                     }*/
           // ListViewItem item = new ListViewItem("gggggggggggggggg");
            //listView1.Items.Add(item);
            
            InitializeComponent();

        }
        private void listView1_load(object sender, EventArgs e)
        {
            
        }
        private void supprimerEtat_Load(object sender, EventArgs e)
        {

        }
        
    }
}