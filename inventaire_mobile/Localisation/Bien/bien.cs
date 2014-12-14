using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Symbol;

namespace inventaire_mobile.Localisation.Bien
{
    public partial class bien : Form
    {
        public string codeEmpla;
        public  string codeSite;
        bien_traitement scntr = new bien_traitement();
        public bien(string codeSite,string codeEmpla)
        {
            this.codeEmpla = codeEmpla;
            this.codeSite = codeSite;
            InitializeComponent();

            scntr.trait_etat(cb_etat);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private API scanAPI = null;
        private EventHandler myReadNotifyHandler = null;


        private void bien_Load(object sender, EventArgs e)
        {
            scanAPI = new API();
            scanAPI.InitReader();
            scanAPI.StartRead(false);
            this.myReadNotifyHandler = new EventHandler(myReader_ReadNotify);
            scanAPI.AttachReadNotify(myReadNotifyHandler);
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Inventaire.Inventaire inv = new Inventaire.Inventaire();
            bien_traitement traitbien=new bien_traitement();
            traitbien.trait_bien(tb_scanBien.Text.ToString(),cb_etat.Text.ToString());
            string inventaire = inv.getInventaire();
            traitbien.remplirSeTrouveBien(inventaire,tb_scanBien.Text.ToString(),cb_etat.Text.ToString(),codeSite,codeEmpla);

            
        }

        


        private void myReader_ReadNotify(object Sender, EventArgs e)
        {
            // Get ReaderData
            Symbol.Barcode.ReaderData TheReaderData = scanAPI.Reader.GetNextReaderData();

            switch (TheReaderData.Result)
            {
                case Symbol.Results.SUCCESS:

                    // Handle the data from this read & submit the next read.

                    this.tb_scanBien.Text = TheReaderData.Text;
                    scanAPI.StartRead(false);

                    break;

                case Symbol.Results.E_SCN_READTIMEOUT:


                    scanAPI.StartRead(false);
                    break;

                case Symbol.Results.CANCELED:

                    break;

                case Symbol.Results.E_SCN_DEVICEFAILURE:

                    scanAPI.StopRead();
                    scanAPI.StartRead(false);
                    break;

                default:

                    string sMsg = "Read Failed\n"
                        + "Result = "
                        + (TheReaderData.Result).ToString();

                    if (TheReaderData.Result == Symbol.Results.E_SCN_READINCOMPATIBLE)
                    {
                        // If the failure is E_SCN_READINCOMPATIBLE, exit the application.
                        MessageBox.Show("AppExitMsg", "Failure");

                        this.Close();
                        return;
                    }
                    break;
            }
        }

        private void tb_codeBienManuel_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void cb_etat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void charger_seTrouveBien()
        {
            
            MessageBox.Show(codeEmpla);
           
        }
        
        
    }
}